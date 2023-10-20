using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpPcap;

using System.Threading;



namespace Sniffer_LLX
{
    public partial class Form1 : Form
    {
        private List<string> capturedPackets = new List<string>();
        private int packetCount = 0;
        private ICaptureDevice selectedDevice;
        private bool capturing = false;
        private Thread captureThread;

        public Form1()
        {
            InitializeComponent();
            selectedDevice = GetSelectedDevice();
        }

        private void show_adapters(object sender, EventArgs e)
        {
            //DateTime currentTime = DateTime.Now;

            //// 将时间格式化为字符串，以便在文本框中显示
            //string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            //// 将格式化后的时间字符串设置为文本框的文本
            //textBox1.Text = formattedTime;
            // 获取网络适配器信息
            var devices = CaptureDeviceList.Instance;

            // 构建一个字符串来存储网卡信息
            StringBuilder deviceInfo = new StringBuilder();
            deviceInfo.AppendLine("Network Adapters:");
            deviceInfo.AppendLine("----------------------------------------------------");

            foreach (var dev in devices)
            {
                deviceInfo.AppendLine(dev.Description);
            }

            // 显示网卡信息在弹窗中
            MessageBox.Show(deviceInfo.ToString(), "Network Adapters");
            textBox1.Text = deviceInfo.ToString();


        }

        private ICaptureDevice GetSelectedDevice()
        {
            var devices = CaptureDeviceList.Instance;
            foreach (var dev in devices)
            {
                if (dev.Description.Contains("Killer Wireless-n/a/ac 1435 Wireless Network Adapter"))
                {
                    return dev;
                }
            }
            return null;
        }


        private void capture_packets(object sender, EventArgs e)
        {
            //// 获取网络适配器信息
            //var devices = CaptureDeviceList.Instance;

            //// 找到指定网卡（Killer Wireless-n/a/ac 1435 Wireless Network Adapter）
            //ICaptureDevice selectedDevice = null;
            //foreach (var dev in devices)
            //{
            //    if (dev.Description.Contains("Killer Wireless-n/a/ac 1435 Wireless Network Adapter"))
            //    {
            //        selectedDevice = dev;
            //        break;
            //    }
            //}

            //if (selectedDevice == null)
            //{
            //    MessageBox.Show("未找到指定的网络适配器。");
            //    return;
            //}

            //// 打开适配器以准备捕获数据包
            //selectedDevice.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
            //selectedDevice.Open(DeviceMode.Promiscuous);
            //selectedDevice.StartCapture();

            //// 捕获10个数据包
            //capturedPackets.Clear(); // 清空之前的捕获数据包
            //packetCount = 0;

            //while (packetCount < 10)
            //{
            //    // 暂停一段时间以等待数据包到达
            //    System.Threading.Thread.Sleep(100);
            //}

            //// 停止捕获
            //selectedDevice.StopCapture();
            //selectedDevice.Close();

            //// 显示捕获的数据包
            //StringBuilder packetInfo = new StringBuilder();
            //packetInfo.AppendLine("Captured Packets:");
            //packetInfo.AppendLine("----------------------------------------------------");

            //foreach (string packet in capturedPackets)
            //{
            //    packetInfo.AppendLine(packet);
            //}

            //// 显示捕获的数据包在弹窗中
            //MessageBox.Show(packetInfo.ToString(), "Captured Packets");

            if (selectedDevice != null)
            {
                if (!capturing)
                {
                    // 清空已捕获的数据包列表
                    capturedPackets.Clear();
                    capturing = true;

                    // 创建一个新线程执行捕获
                    captureThread = new Thread(CaptureThread);
                    captureThread.Start();
                }
            }
            else
            {
                MessageBox.Show("未找到指定的网络适配器。");
            }

        }

        //private void OnPacketArrival(object sender, CaptureEventArgs e)
        //{
        //    // 处理捕获到的数据包
        //    var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
        //    capturedPackets.Add(packet.ToString());
        //    packetCount++;
        //}

        private void stop_capture(object sender, EventArgs e)
        {
            if (capturing)
            {
                capturing = false;
                if (captureThread != null)
                {
                    captureThread.Join(); // 等待线程结束
                }
            }
        }

        private void CaptureThread()
        {
            selectedDevice.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
            selectedDevice.Open(DeviceMode.Promiscuous);
            selectedDevice.StartCapture();

            while (capturing)
            {
                // 继续监听，不断捕获数据包
                Thread.Sleep(100);
            }

            // 停止捕获
            selectedDevice.OnPacketArrival -= new PacketArrivalEventHandler(OnPacketArrival);
            selectedDevice.StopCapture();
            selectedDevice.Close();
        }

        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            if (capturing)
            {
                try
                {
                    // 处理捕获到的数据包
                    var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
                    string packetInfo = packet.ToString();

                    // 添加数据包到列表
                    capturedPackets.Add(packetInfo);

                    // 更新ListBox显示
                    UpdatePacketListBox();

                    // 限制捕获数据包的数量为1000
                    if (capturedPackets.Count > 1000)
                    {
                        capturedPackets.RemoveAt(0); // 移除最旧的包
                    }
                }
                catch (Exception ex)
                {
                    // 记录异常信息
                    capturedPackets.Add("Error: " + ex.Message);
                    UpdatePacketListBox();
                }
            }
        }


        private void UpdatePacketListBox()
        {
            // 更新ListBox显示
            if (listBox1.InvokeRequired)
            {
                listBox1.BeginInvoke((MethodInvoker)delegate
                {
                    listBox1.BeginUpdate();
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(capturedPackets.ToArray());
                    listBox1.EndUpdate();
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                });
            }
            else
            {
                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(capturedPackets.ToArray());
                listBox1.EndUpdate();
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }
    }
}