using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace KheperaMapGenerator
{
    public class TcpConnection
    {
        public TcpClient client;
        public void TcpServer()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 5004);
            tcpListener.Start();

            while (true)
            {
                client = tcpListener.AcceptTcpClient();
                Thread tcpHandlerThread = new Thread(new ParameterizedThreadStart(tcpHandler));
                tcpHandlerThread.Start(client);
                if (client.Connected)
                {
                    MainApplication mainApplication = new MainApplication();
                    mainApplication.startRobot.Enabled = true;
                    break;
                }
            }
        }

        private void tcpHandler(object client)
        {
            TcpClient mClient = (TcpClient)client;
            NetworkStream stream = mClient.GetStream();

        }
    }
}

