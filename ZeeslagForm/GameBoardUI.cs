using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeeslagForm
{
    public partial class GameBoardUI : UserControl
    {
        public GameBoardUI()
        {
            InitializeComponent();
        }

        internal void PlaceShips(ZeeslagLib.Ship[] ships)
        {
            for(int i=0;i<10;i++)
                for(int j=0;j<10;j++)
                {
                    Panel p = new Panel();
                    tableLayoutPanel1.Controls.Add(p, i, j);
                    p.Dock = DockStyle.Fill;
                    //p.BackColor = Color.Blue;
                }

            foreach(var ship in ships)
            {
                for (int i = 0; i < ship.afmeting; i++)
                {
                    Panel p;
                    if (ship.position == "horizontaal")
                        p = (Panel)tableLayoutPanel1.GetControlFromPosition(ship.x + i, ship.y);
                    else
                        p = (Panel)tableLayoutPanel1.GetControlFromPosition(ship.x, ship.y + i);
                    p.BackColor = Color.Black;
                }
                

                

            }
        }
    }
}
