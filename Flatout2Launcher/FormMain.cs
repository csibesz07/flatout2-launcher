using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Flatout2Launcher
{
    public partial class FormMain : Form
    {
        private List<string> ipList;
        public FormMain()
        {
            InitializeComponent();

            /* Get ip's and fill combo box */
            ipList = new List<string>();
            GetIPAddresses();
        }

        private void GetIPAddresses()
        {
            int numberOfIPs=0;
            // Get a list of all network interfaces (usually one per network card, dialup, and VPN connection) 
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface network in networkInterfaces)
            {
                // Read the IP configuration for each network 
                IPInterfaceProperties properties = network.GetIPProperties();

                // Each network interface may have multiple IP addresses 
                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    // We're only interested in IPv4 addresses for now 
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    // Ignore loopback addresses (e.g., 127.0.0.1) 
                    if (IPAddress.IsLoopback(address.Address))
                        continue;

                    comboBox1.Items.Add(address.Address.ToString() + " (" + network.Name + ")");
                    ipList.Add(address.Address.ToString());
                    numberOfIPs++;
                }
            }

            if (numberOfIPs > 0) {
                comboBox1.SelectedIndex = 0;
            }
        }

        private int LaunchGame(string args) {
            int exitCode = -1;

            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();

            start.Arguments = args;
            start.FileName = "flatout2.exe";

            // Run the external process & wait for it to finish
            try
            {
                using (Process proc = Process.Start(start))
                {
                    proc.WaitForExit();

                    // Retrieve the app's exit code
                    exitCode = proc.ExitCode;
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            return exitCode;
        }

        private bool ValidateIP(string ip) {
            int count = 0;
            string[] words = ip.Split('.');

            foreach (string word in words)
            {
                count++;

                try
                {
                    int temp = Convert.ToInt32(word);

                    if (temp < 0 || temp > 255)
                    {
                        return false;
                    }
                }
                    catch (Exception e) {
                        return false;
                    }

            }

            if (count != 4) {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
             switch (mainTabControl.SelectedIndex) { 
                /* Client */
                case 0:
                    if (ValidateIP(textBoxClient_ServerIP.Text))
                    {
                        LaunchGame("-join=" + textBoxClient_ServerIP.Text + " -lan");
                    }
                    else {
                        MessageBox.Show("Invalid IP!");
                    }
                    break;

                /* Server */
                case 1:
                    string ip = ipList[comboBox1.SelectedIndex];
                    if (ValidateIP(ip))
                    {
                        LaunchGame("-host -lan -private_addr=" + ip);
                    }
                    else
                    {
                        MessageBox.Show("Invalid IP!");
                    }    
                    break;

                /* Options */
                case 2:
                    LaunchGame("-setup");
                    break;

                /* Single Player */
                case 3:
                    LaunchGame("");
                    break;

                default:
                    break;
            }
            
        }

    }
}
