using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
using System.Management;


namespace KheperaMapGenerator
{
    public partial class NetworkScanner : Form
    {
        MainApplication main = new MainApplication();
        public NetworkScanner()
        {
            InitializeComponent();

            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Text = "Idle";
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Thread myThread = null;

        public void scan(string subnet)
        {
            Ping myPing;
            PingReply reply;
            IPAddress addr;
            IPHostEntry host;

            progressBar1.Maximum = 254;
            progressBar1.Value = 0;
            listVAddr.Items.Clear();

            for (int i = 1; i < 255; i++)
            {
                string subnetn = "." + i.ToString();
                myPing = new Ping();
                reply = myPing.Send(subnet + subnetn, 900);

                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Scanning: " + subnet + subnetn;

                if (reply.Status == IPStatus.Success)
                {
                    try
                    {
                        addr = IPAddress.Parse(subnet + subnetn);
                        listVAddr.Items.Add(new ListViewItem(new String[] { subnet + subnetn }));
                    }
                    catch { MessageBox.Show("Couldnt retrieve hostname for " + subnet + subnetn, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                progressBar1.Value += 1;
            }
            cmdScan.Enabled = true;
            cmdStop.Enabled = false;
            txtIP.Enabled = true;
            lblStatus.Text = "Done!";
            int count = listVAddr.Items.Count;
            MessageBox.Show("Scanning done!\nFound " + count.ToString() + " hosts.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == string.Empty)
            {
                MessageBox.Show("No IP address entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myThread = new Thread(() => scan(txtIP.Text));
                myThread.Start();

                if (myThread.IsAlive == true)
                {
                    cmdStop.Enabled = true;
                    cmdScan.Enabled = false;
                    txtIP.Enabled = false;
                }
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            myThread.Suspend();
            cmdScan.Enabled = true;
            cmdStop.Enabled = false;
            txtIP.Enabled = true;
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Text = "Idle";
        }   

        private void connectToClient_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listVAddr.SelectedItems[0];
            string ip = selectedItem.SubItems[0].Text;
            TcpConnection tcpConnection = new TcpConnection();
            tcpConnection.TcpServer();

            main.startRobot.Enabled = true;
            Hide(); 
        }

        private void listVAddr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listVAddr.SelectedItems.Count > 0)
            {
                connectToClient.Enabled = true;
            }
        }
    }
}
