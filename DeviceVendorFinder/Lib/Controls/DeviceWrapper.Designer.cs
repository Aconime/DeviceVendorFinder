
namespace UIComponents
{
    partial class DeviceWrapper
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlBorder = new System.Windows.Forms.Panel();
            this.controlBackground = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.macVendor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.macAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceTitle = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlBorder.SuspendLayout();
            this.controlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBorder
            // 
            this.controlBorder.BackColor = System.Drawing.Color.Silver;
            this.controlBorder.Controls.Add(this.controlBackground);
            this.controlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlBorder.Location = new System.Drawing.Point(0, 0);
            this.controlBorder.Name = "controlBorder";
            this.controlBorder.Size = new System.Drawing.Size(375, 134);
            this.controlBorder.TabIndex = 0;
            // 
            // controlBackground
            // 
            this.controlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.controlBackground.Controls.Add(this.pictureBox1);
            this.controlBackground.Controls.Add(this.label6);
            this.controlBackground.Controls.Add(this.macVendor);
            this.controlBackground.Controls.Add(this.label8);
            this.controlBackground.Controls.Add(this.macAddress);
            this.controlBackground.Controls.Add(this.label4);
            this.controlBackground.Controls.Add(this.ipAddress);
            this.controlBackground.Controls.Add(this.label2);
            this.controlBackground.Controls.Add(this.deviceTitle);
            this.controlBackground.Controls.Add(this.hostName);
            this.controlBackground.Location = new System.Drawing.Point(1, 1);
            this.controlBackground.Name = "controlBackground";
            this.controlBackground.Size = new System.Drawing.Size(373, 132);
            this.controlBackground.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(7, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mac Vendor:";
            // 
            // macVendor
            // 
            this.macVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.macVendor.AutoEllipsis = true;
            this.macVendor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.macVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.macVendor.Location = new System.Drawing.Point(105, 108);
            this.macVendor.Name = "macVendor";
            this.macVendor.Size = new System.Drawing.Size(259, 15);
            this.macVendor.TabIndex = 8;
            this.macVendor.Text = "CANON INC.";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(7, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mac Address:";
            // 
            // macAddress
            // 
            this.macAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.macAddress.AutoEllipsis = true;
            this.macAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.macAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.macAddress.Location = new System.Drawing.Point(105, 88);
            this.macAddress.Name = "macAddress";
            this.macAddress.Size = new System.Drawing.Size(261, 15);
            this.macAddress.TabIndex = 6;
            this.macAddress.Text = "CF-0A-FF-92-AC-BF";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP Address:";
            // 
            // ipAddress
            // 
            this.ipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddress.AutoEllipsis = true;
            this.ipAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ipAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ipAddress.Location = new System.Drawing.Point(105, 68);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(259, 15);
            this.ipAddress.TabIndex = 4;
            this.ipAddress.Text = "192.168.48.184";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host Name:";
            // 
            // deviceTitle
            // 
            this.deviceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceTitle.AutoEllipsis = true;
            this.deviceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deviceTitle.Location = new System.Drawing.Point(5, 7);
            this.deviceTitle.Name = "deviceTitle";
            this.deviceTitle.Size = new System.Drawing.Size(363, 23);
            this.deviceTitle.TabIndex = 0;
            this.deviceTitle.Text = "DEVICE 1";
            this.deviceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hostName
            // 
            this.hostName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostName.AutoEllipsis = true;
            this.hostName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hostName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.hostName.Location = new System.Drawing.Point(105, 48);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(261, 15);
            this.hostName.TabIndex = 2;
            this.hostName.Text = "DESKTOP-C92KW01LS-1293";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(9, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 1);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DeviceWrapper
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.controlBorder);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeviceWrapper";
            this.Size = new System.Drawing.Size(375, 134);
            this.controlBorder.ResumeLayout(false);
            this.controlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlBorder;
        private System.Windows.Forms.Panel controlBackground;
        private System.Windows.Forms.Label deviceTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hostName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label macVendor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label macAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
