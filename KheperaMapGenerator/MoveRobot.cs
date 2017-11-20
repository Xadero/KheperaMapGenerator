using System.IO;
using System.Windows.Forms;

namespace KheperaMapGenerator
{
    class MoveRobot
    {
        MainApplication main = new MainApplication();

        char getChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }

        public void Movement()
        {
            TcpConnection clientConnection = new TcpConnection();
            KeyEventArgs e = null;
            //NetworkStream stream = clientConnection.client.GetStream();
            StreamReader reader = new StreamReader(clientConnection.client.GetStream());

            while (clientConnection.client.Connected)
            {
                char keyPressed = getChar(e); //If the string is null, the connection has been lost.
            }

            
            switch (e.KeyCode)
            {
                case Keys.Up:
                    main.UpArrow.PerformClick();
                    break;

                case Keys.Down:
                    main.DownArrow.PerformClick();
                    break;

                case Keys.Left:
                    main.LeftArrow.PerformClick();
                    break;

                case Keys.Right:
                    main.RightArrow.PerformClick();
                    break;

                default:
                    break;
            }
        }
    }
}
