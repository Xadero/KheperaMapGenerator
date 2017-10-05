using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace KheperaMapGenerator
{
    public partial class ClientManager : Form
    {
        ApManager apManager = new ApManager();
        Ping myPing;
        PingReply pingReply;
        IPAddress ipAddress;
        PhysicalAddress macAddress;
        IPHostEntry iPHostEntry;
        public ClientManager()
        {
            InitializeComponent();
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientSearchButton_Click(object sender, EventArgs e)
        {
            string host = apManager.getNetworkIP().Substring(0, 10);
            //Scan(host);
        }

        private void connectToClientBtn_Click(object sender, EventArgs e)
        {

        }

        public void Scan(string subnet)
        {
            for (int i = 1; i < 255; i++)
            {
                string subnetn = "." + i.ToString();
                myPing = new Ping();
                pingReply = myPing.Send(subnet + subnetn);

                if(pingReply.Status == IPStatus.Success)
                {
                    try
                    {
                        ipAddress = IPAddress.Parse(subnet + subnetn);
                        iPHostEntry = Dns.GetHostEntry(ipAddress);
                        macAddress = PhysicalAddress.Parse(subnet + subnetn);
                        clientList.Items.Add(new ListViewItem(new String[] { iPHostEntry.HostName, subnet + subnetn, macAddress.ToString() }));
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
