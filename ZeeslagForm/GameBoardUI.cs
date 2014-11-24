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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Clickable { get; set; }

        public GameBoardUI()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    Panel p = new Panel();
                    tableLayoutPanel1.Controls.Add(p, i, j);
                    p.Dock = DockStyle.Fill;
                    p.BackColor = Color.LawnGreen;

                    p.Click += panel_Click;
                }
        }

        void panel_Click(object sender, EventArgs e)
        {
            if (Clickable)
            {
                var p = sender as Panel;
                p.BackColor = Color.Red;

                var pos = this.tableLayoutPanel1.GetCellPosition(p);
                Game.Shoot( new int[]{pos.Row, pos.Column});
            }
        }

        internal void PlaceShips(ZeeslagLib.Ship[] ships)
        {
            

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

        public ZeeslagLib.Game Game { get; set; }
    }
}
