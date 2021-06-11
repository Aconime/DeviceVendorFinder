using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UIComponents
{
    public partial class DeviceWrapper : UserControl
    {
        public DeviceWrapper()
        {
            InitializeComponent();

            // Optional Settings / Preferences
            Dock = DockStyle.Top;

            // Init properties
            DeviceTitleText = deviceTitleText;
            HostNameText = hostNameText;
            IPAddressText = ipAddressText;
            MacAddressText = macAddressText;
            MacVendorText = macVendorText;

            // Event Handlers
            Load += new EventHandler(DeviceWrapper_Load);
            Resize += new EventHandler(DeviceWrapper_Resize);
        }

        // Height Variable
        private int controlFixedHeight = 134;

        // Values for the custom properties
        private string deviceTitleText = "";
        private string hostNameText = "";
        private string ipAddressText = "";
        private string macAddressText = "";
        private string macVendorText = "";

        #region "Custom Properties for the control"
        [Category("Custom Properties"), Description("The device's Title or Name.")]
        public string DeviceTitleText
        {
            get => deviceTitleText;
            set { deviceTitleText = value; deviceTitle.Text = deviceTitleText; }
        }

        [Category("Custom Properties"), Description("The device's Host Name.")]
        public string HostNameText
        {
            get => hostNameText;
            set { hostNameText = value; hostName.Text = hostNameText; }
        }

        [Category("Custom Properties"), Description("The device's IP Address.")]
        public string IPAddressText
        {
            get => ipAddressText;
            set { ipAddressText = value; ipAddress.Text = ipAddressText; }
        }

        [Category("Custom Properties"), Description("The device's Mac Address.")]
        public string MacAddressText
        {
            get => macAddressText;
            set { macAddressText = value; macAddress.Text = macAddressText; }
        }

        [Category("Custom Properties"), Description("The device's Mac Vendor Name or Company Title.")]
        public string MacVendorText
        {
            get => macVendorText;
            set { macVendorText = value; macVendor.Text = macVendorText; }
        }
        #endregion

        private void DeviceWrapper_Load(object sender, EventArgs e) { }

        private void DeviceWrapper_Resize(object sender, EventArgs e) => Height = controlFixedHeight;
    }
}
