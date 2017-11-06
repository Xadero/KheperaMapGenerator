using KheperaMapGenerator.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;
using SimpleWifi.Win32;

namespace KheperaMapGenerator
{
    public partial class MainApplication : Form
    {

        private static ApManager wifi;
        private static NetworkScanner scanner;

        public MainApplication()
        {
            InitializeComponent();
        }

        private void ExportMap_Click(object sender, EventArgs e)
        {
            ExportMapToFile exportMapToFile = new ExportMapToFile();
            exportMapToFile.ExportMap(generatedMap);
        }

        private void OpenKheperaManual(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = @"Manual.pdf";
            process.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                generatedMap.Image = null;
            }
            else
            {
                // user clicked no
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatedMap.Image = Image.FromFile(@"C:\Users\Gumiś\Desktop\Studia\Platforma .NET\Laboratorium\KheperaMapGenerator\KheperaMapGenerator\Hearthstone Screenshot 08-11-17 20.42.54.png");
        }

        private void connectApButton_Click(object sender, EventArgs e)
        {
            wifi = new ApManager();
            wifi.ShowDialog();
        }

        private void generatedMap_Click(object sender, EventArgs e)
        {

        }

        private void MainApplication_Load(object sender, EventArgs e)
        {

        }

        private void startRobot_Click(object sender, EventArgs e)
        {
            UpArrow.Enabled = true;
            DownArrow.Enabled = true;
            LeftArrow.Enabled = true;
            RightArrow.Enabled = true;

            MoveRobot moveRobot = new MoveRobot();
            moveRobot.Movement();
        }
    }
}
