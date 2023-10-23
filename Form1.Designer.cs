namespace Sniffer_LLX
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "显示网卡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_adapters);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(862, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "抓包启动";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.capture_packets);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(765, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(519, 304);
            this.listBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "抓包停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.stop_capture);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.macSource,
            this.macDestination,
            this.ipSource,
            this.ipDestination,
            this.dataLength});
            this.dataGridView1.Location = new System.Drawing.Point(34, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 244);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // id
            // 
            this.id.FillWeight = 44.64286F;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // macSource
            // 
            this.macSource.FillWeight = 120.1765F;
            this.macSource.HeaderText = "源MAC";
            this.macSource.MinimumWidth = 6;
            this.macSource.Name = "macSource";
            this.macSource.ReadOnly = true;
            this.macSource.Width = 135;
            // 
            // macDestination
            // 
            this.macDestination.FillWeight = 114.6958F;
            this.macDestination.HeaderText = "目的MAC";
            this.macDestination.MinimumWidth = 6;
            this.macDestination.Name = "macDestination";
            this.macDestination.ReadOnly = true;
            this.macDestination.Width = 128;
            // 
            // ipSource
            // 
            this.ipSource.FillWeight = 110.2345F;
            this.ipSource.HeaderText = "源IP";
            this.ipSource.MinimumWidth = 6;
            this.ipSource.Name = "ipSource";
            this.ipSource.ReadOnly = true;
            this.ipSource.Width = 124;
            // 
            // ipDestination
            // 
            this.ipDestination.FillWeight = 106.6031F;
            this.ipDestination.HeaderText = "目的IP";
            this.ipDestination.MinimumWidth = 6;
            this.ipDestination.Name = "ipDestination";
            this.ipDestination.ReadOnly = true;
            this.ipDestination.Width = 119;
            // 
            // dataLength
            // 
            this.dataLength.FillWeight = 103.6472F;
            this.dataLength.HeaderText = "数据段长度";
            this.dataLength.MinimumWidth = 6;
            this.dataLength.Name = "dataLength";
            this.dataLength.ReadOnly = true;
            this.dataLength.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn macSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn macDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLength;
    }
}

