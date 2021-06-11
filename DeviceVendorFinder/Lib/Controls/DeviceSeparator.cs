using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeviceVendorFinder.Lib.Controls
{
    public partial class DeviceSeparator : UserControl
    {
        public DeviceSeparator()
        {
            InitializeComponent();

            // Optional Settings / Preferences
            BackColor = Color.Transparent;
            Dock = DockStyle.Top;

            // Event Handlers
            Resize += new EventHandler(DeviceSeparator_Resize);
        }

        // Height Variable
        private int controlFixedHeight = 10;
        private void DeviceSeparator_Resize(object sender, EventArgs e) => Height = controlFixedHeight;
    }
}
