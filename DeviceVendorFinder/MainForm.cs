using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using DeviceVendorFinder.Lib.Controls;
using NetworkFunctions;
using UIComponents;

namespace DeviceVendorFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Event Handlers
            scanDevices.Click += new EventHandler(ScanDevices_Click);
        }

        public static int totalDevicesFound = 0;
        public static List<DeviceWrapper> devices;

        public bool CheckConnection()
        {
            bool checkConnection = CheckNetworkConnection.HasNetworkConnection();

            if (!checkConnection)
            {
                MessageBox.Show("You are not connected to a network. Please try again later.");
                connectionStatus.Text = "Disconnected";
                connectionStatus.ForeColor = Color.Red;
            } else
            {
                connectionStatus.Text = "Connected";
                connectionStatus.ForeColor = Color.Green;
            }

            return checkConnection;
        }

        private void MainForm_Load(object sender, EventArgs e) => CheckConnection();

        private void ScanDevices_Click(object sender, EventArgs e) => ScanDevices();

        // Scan for devices method
        #region "Scan devices and display in the list (Panel)"
        private async void ScanDevices()
        {
            if (CheckConnection())
            {
                scanStatus.Text = "Scanning...";

                deviceList.Controls.Clear();

                string gatewayIP = NetworkGateway.Gateway();
                string[] gatewaySplitter = gatewayIP.Split('.');
                List<String> listOfHosts = new List<String>();

                for (int i = 2; i <= 255; i++)
                    listOfHosts.Add(gatewaySplitter[0] + "." + gatewaySplitter[1] + "." + gatewaySplitter[2] + "." + i);

                List<PingReply> results = await PingNetwork.PingHost(listOfHosts, 4000);

                devices = new List<DeviceWrapper>();

                for (int j = 0; j <= results.Count() - 1; j++)
                {
                    if (results[j].Status == IPStatus.Success)
                    {
                        totalDevicesFound += 1;
                        string macaddres = GetNetworkInfo.GetMacAddress(listOfHosts[j].ToString());
                        string hostname = GetNetworkInfo.GetHostName(listOfHosts[j].ToString());
                        string[] arr = new string[3];

                        arr[0] = listOfHosts[j].ToString();
                        arr[1] = macaddres;
                        arr[2] = hostname;

                        DeviceWrapper device = new DeviceWrapper();
                        device.DeviceTitleText = "DEVICE " + totalDevicesFound;
                        device.HostNameText = arr[2];
                        device.IPAddressText = arr[0];
                        device.MacAddressText = arr[1];

                        try
                        {
                            bool vendorFound = false;
                            string[] macAddressSplitter = arr[1].Split('-');
                            string macAddress = (macAddressSplitter[0] + macAddressSplitter[1] + macAddressSplitter[2]).ToUpper();

                            string[] macVendorLines = File.ReadAllLines("./mac-vendors-db.txt");

                            for (int i = 0; i <= macVendorLines.Count() - 1; i++)
                            {
                                string[] splitter = macVendorLines[i].Split('~');

                                if (splitter[0] == macAddress)
                                {
                                    device.MacVendorText = splitter[1];
                                    vendorFound = true;
                                    break;
                                }
                            }

                            if (vendorFound == false) device.MacVendorText = "Vendor not found.";
                        }
                        catch { device.MacVendorText = "Vendor not found."; }

                        devices.Add(device);
                    }
                }

                for (int i = devices.Count() - 1; i >= 0; i--)
                {
                    deviceList.Controls.Add(devices[i]);
                    DeviceSeparator deviceSep = new DeviceSeparator();
                    deviceList.Controls.Add(deviceSep);
                }

                scanStatus.Text = "Complete";
                devicesFound.Text = "Devices Found: " + devices.Count();
            }
        }
        #endregion

    }
}
