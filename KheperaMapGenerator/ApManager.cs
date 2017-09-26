using System;
using System.Windows.Forms;
using SimpleWifi;
using System.Collections.Generic;

namespace KheperaMapGenerator
{
    public partial class ApManager : Form
    {
        private static Wifi wifi;
        public int selectedItems;
        public bool connectionStatus = false;
        public ListViewItem selectedItem;
        MainApplication mainApplication = new MainApplication();

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

        private void apSearchButton_Click(object sender, EventArgs e)
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
                    MessageBox.Show("You connected succefully /nto the network: " + ap.Name);
                    connectionStatus = true;
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Connectio failed");
                }
            }
        }
        private bool checAuthRequest(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap);
            authRequest.Password = password;
            return ap.Connect(authRequest);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
