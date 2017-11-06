using System;
using System.Windows.Forms;
using SimpleWifi;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.ComponentModel;

namespace KheperaMapGenerator
{
    public partial class ApManager : Form
    {

        private static Wifi wifi;
        public int selectedItems;
        public bool connectionStatus = false;
        public ListViewItem selectedItem;
        public string ip;
        MainApplication mainApplication = new MainApplication();
        BackgroundWorker bgw = new BackgroundWorker();
        Thread myThread = null;
        private static NetworkScanner scanner = new NetworkScanner();

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

            foreach (AccessPoint ap in accessPoints)
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
                    adapterBtn.Enabled = true;
                    adapterList.Enabled = true;
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
            clientSearchButton.Enabled = true;

        }

        public void clientSearchButton_Click(object sender, EventArgs e)
        {
            string adapterIP = ip.Substring(0, 9);
            scanner.txtIP.Text = adapterIP;
            scanner.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            for (int i = 0; i <= 255; i++)
            {
                int percents = (i * 100) / 255;
                backgroundWorker1.ReportProgress(percents, i);
                Thread.Sleep(100);
            }
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void connectToClientBtn_Click(object sender, EventArgs e)
        {
            TcpConnection tcpConnection = new TcpConnection();
            Thread tcpServerRunThread = new Thread(() => tcpConnection.TcpServer(ip));
            tcpServerRunThread.Start();
        }
    }
}
