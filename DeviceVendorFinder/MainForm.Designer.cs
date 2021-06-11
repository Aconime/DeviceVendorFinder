
namespace DeviceVendorFinder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.devicesFound = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scanStatus = new System.Windows.Forms.Label();
            this.scanDevices = new System.Windows.Forms.Button();
            this.deviceList = new System.Windows.Forms.Panel();
            this.startLoader = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.connectionStatus,
            this.devicesFound});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "Satus:";
            // 
            // connectionStatus
            // 
            this.connectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.connectionStatus.ForeColor = System.Drawing.Color.Green;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(65, 17);
            this.connectionStatus.Text = "Connected";
            // 
            // devicesFound
            // 
            this.devicesFound.BackColor = System.Drawing.Color.Transparent;
            this.devicesFound.Name = "devicesFound";
            this.devicesFound.Size = new System.Drawing.Size(578, 17);
            this.devicesFound.Spring = true;
            this.devicesFound.Text = "Devices Found: 0";
            this.devicesFound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.devicesFound.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 363);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(686, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 363);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.scanStatus);
            this.panel3.Controls.Add(this.scanDevices);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 46);
            this.panel3.TabIndex = 4;
            // 
            // scanStatus
            // 
            this.scanStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.scanStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scanStatus.Location = new System.Drawing.Point(582, 9);
            this.scanStatus.Name = "scanStatus";
            this.scanStatus.Size = new System.Drawing.Size(104, 28);
            this.scanStatus.TabIndex = 2;
            this.scanStatus.Text = "Complete";
            this.scanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scanDevices
            // 
            this.scanDevices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scanDevices.Location = new System.Drawing.Point(9, 9);
            this.scanDevices.Name = "scanDevices";
            this.scanDevices.Size = new System.Drawing.Size(95, 28);
            this.scanDevices.TabIndex = 0;
            this.scanDevices.Text = "SCAN LAN";
            this.scanDevices.UseVisualStyleBackColor = true;
            // 
            // deviceList
            // 
            this.deviceList.AutoScroll = true;
            this.deviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceList.Location = new System.Drawing.Point(10, 46);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(676, 363);
            this.deviceList.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 431);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Mac-Vendor Finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel connectionStatus;
        public System.Windows.Forms.ToolStripStatusLabel devicesFound;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel deviceList;
        public System.Windows.Forms.Button scanDevices;
        public System.Windows.Forms.Label scanStatus;
        public System.Windows.Forms.Timer startLoader;
    }
}

