using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace KheperaMapGenerator
{
    public class TcpConnection
    {

        public void TcpServer()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 5004);
            tcpListener.Start();

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Thread tcpHandlerThread = new Thread(new ParameterizedThreadStart(tcpHandler));
                tcpHandlerThread.Start(client);
            }
        }

        private void tcpHandler(object client)
        {
            TcpClient mClient = (TcpClient)client;
            NetworkStream stream = mClient.GetStream();

        }
    }
}

