using System;
using System.Windows.Forms;
using SimpleWifi;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace KheperaMapGenerator
{
    public partial class ApManager : Form
    {

        private static Wifi wifi;
        public int selectedItems;
        public bool connectionStatus = false;
        public ListViewItem selectedItem;

        MainApplication mainApplication = new MainApplication();
        Ping myPing;
        PingReply pingReply;
        IPAddress ipAddress;
        IPHostEntry iPHostEntry;
        string ip;

        public ApManager()
        {
            InitializeComponent();
        }
        private void ApManager_Load(object sender, EventArgs e)
        {

        }

        private void apList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (apList.SelectedItems.Count > 0)
            {
                connectButton.Enabled = true;
                passwordTb.Enabled = true;
                SsidLabel.Text = apList.SelectedItems[0].Text;
            }
        }

        public void apSearchButton_Click(object sender, EventArgs e)
        {
            apList.Items.Clear();
            wifi = new Wifi();
            List<AccessPoint> accessPoints = wifi.GetAccessPoints();
            
            foreach(AccessPoint ap in accessPoints)
            {
                ListViewItem lvItem = new ListViewItem(ap.Name);
                lvItem.SubItems.Add(ap.SignalStrength + "%");
                lvItem.Tag = ap;
                apList.Items.Add(lvItem);
            }

            accessPoints.Clear();
        }
        private void conenctToAp_Click(object sender, EventArgs e)
        {
            if (apList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = apList.SelectedItems[0];
                AccessPoint ap = (AccessPoint)selectedItem.Tag;

                if (checAuthRequest(ap, passwordTb.Text))
                {
                    MessageBox.Show("You connected succefully to the network: " + ap.Name);
                    connectionStatus = true;
                }
                else
                {
                    MessageBox.Show("Connectio failed");
                }
                getNetworkIP();

            }
        }
        private bool checAuthRequest(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap);
            authRequest.Password = password;
            return ap.Connect(authRequest);
        }

        public void Disconect(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap);
            authRequest.Password = password;
            ap.DeleteProfile();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void getNetworkIP()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    Console.WriteLine(ni.Name);
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            ip.Address.ToString();
                            adapterList.Items.Add(new ListViewItem(new String[] { ni.Description, ip.Address.ToString() }));
                        }
                    }
                }
            }
        }

        public void adapterBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = adapterList.SelectedItems[0];
            hostlbl.Text = selectedItem.SubItems[0].Text;
            ip = selectedItem.SubItems[1].Text;

        }

        private void clientSearchButton_Click(object sender, EventArgs e)
        {
            string adapterIP = ip.Substring(0, 9);
            Scan(adapterIP);
        }

        public void Scan(string subnet)
        {
            for (int i = 107; i < 109; i++)
            {
                string subnetn = "." + i.ToString();
                myPing = new Ping();
                pingReply = myPing.Send(subnet + subnetn);

                if (pingReply.Status == IPStatus.Success)
                {
                    try
                    {
                        ipAddress = IPAddress.Parse(subnet + subnetn);
                        iPHostEntry = Dns.GetHostEntry(ipAddress);
                        clientList.Items.Add(new ListViewItem(new String[] { iPHostEntry.HostName, subnet + subnetn }));
                    }
                    catch
                    {
                        Console.WriteLine("Couldn't retrive hostname or MAC for " + subnet + subnetn, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
