using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KheperaMapGenerator
{
    class MoveRobot
    {
        MainApplication main = new MainApplication();
        public void Movement()
        {
            KeyEventArgs e = null;
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
