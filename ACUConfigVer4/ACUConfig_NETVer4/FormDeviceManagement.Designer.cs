namespace ACUConfig_NETVer4
{
    partial class FormDeviceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column设备名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column设备IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column目的IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column模式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTCP连接 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column虚拟串口号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column虚拟串口状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column设备ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_StartSearchDev = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonEditDevice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column类型,
            this.Column设备名称,
            this.Column设备IP,
            this.Column目的IP,
            this.Column模式,
            this.ColumnTCP连接,
            this.Column虚拟串口号,
            this.Column虚拟串口状态,
            this.Column设备ID});
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(850, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column类型
            // 
            this.Column类型.HeaderText = "类型";
            this.Column类型.Name = "Column类型";
            this.Column类型.ReadOnly = true;
            this.Column类型.Width = 54;
            // 
            // Column设备名称
            // 
            this.Column设备名称.HeaderText = "设备名称";
            this.Column设备名称.Name = "Column设备名称";
            this.Column设备名称.ReadOnly = true;
            this.Column设备名称.Width = 90;
            // 
            // Column设备IP
            // 
            this.Column设备IP.HeaderText = "设备IP";
            this.Column设备IP.Name = "Column设备IP";
            this.Column设备IP.ReadOnly = true;
            // 
            // Column目的IP
            // 
            this.Column目的IP.HeaderText = "目的IP";
            this.Column目的IP.Name = "Column目的IP";
            this.Column目的IP.ReadOnly = true;
            // 
            // Column模式
            // 
            this.Column模式.HeaderText = "模式";
            this.Column模式.Name = "Column模式";
            this.Column模式.ReadOnly = true;
            // 
            // ColumnTCP连接
            // 
            this.ColumnTCP连接.HeaderText = "TCP连接";
            this.ColumnTCP连接.Name = "ColumnTCP连接";
            this.ColumnTCP连接.ReadOnly = true;
            this.ColumnTCP连接.Width = 72;
            // 
            // Column虚拟串口号
            // 
            this.Column虚拟串口号.HeaderText = "虚拟串口号";
            this.Column虚拟串口号.Name = "Column虚拟串口号";
            this.Column虚拟串口号.ReadOnly = true;
            this.Column虚拟串口号.Width = 90;
            // 
            // Column虚拟串口状态
            // 
            this.Column虚拟串口状态.FillWeight = 200F;
            this.Column虚拟串口状态.HeaderText = "虚拟串口状态";
            this.Column虚拟串口状态.Name = "Column虚拟串口状态";
            this.Column虚拟串口状态.ReadOnly = true;
            // 
            // Column设备ID
            // 
            this.Column设备ID.FillWeight = 200F;
            this.Column设备ID.HeaderText = "设备ID";
            this.Column设备ID.Name = "Column设备ID";
            this.Column设备ID.ReadOnly = true;
            // 
            // button_StartSearchDev
            // 
            this.button_StartSearchDev.Location = new System.Drawing.Point(859, 36);
            this.button_StartSearchDev.Name = "button_StartSearchDev";
            this.button_StartSearchDev.Size = new System.Drawing.Size(75, 23);
            this.button_StartSearchDev.TabIndex = 1;
            this.button_StartSearchDev.Text = "自动搜索";
            this.button_StartSearchDev.UseVisualStyleBackColor = true;
            this.button_StartSearchDev.Click += new System.EventHandler(this.button_StartSearchDev_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(954, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "状态栏";
            // 
            // buttonEditDevice
            // 
            this.buttonEditDevice.Location = new System.Drawing.Point(859, 135);
            this.buttonEditDevice.Name = "buttonEditDevice";
            this.buttonEditDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDevice.TabIndex = 3;
            this.buttonEditDevice.Text = "编辑设备";
            this.buttonEditDevice.UseVisualStyleBackColor = true;
            this.buttonEditDevice.Click += new System.EventHandler(this.buttonEditDevice_Click);
            // 
            // FormDeviceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 352);
            this.Controls.Add(this.buttonEditDevice);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_StartSearchDev);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDeviceManagement";
            this.Text = "设备管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeviceManagement_FormClosing);
            this.Load += new System.EventHandler(this.FormDeviceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column设备名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column设备IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column目的IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column模式;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTCP连接;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column虚拟串口号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column虚拟串口状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column设备ID;
        private System.Windows.Forms.Button button_StartSearchDev;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonEditDevice;
    }
}