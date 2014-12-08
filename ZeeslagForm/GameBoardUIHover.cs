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
    public partial class GameBoardUIHover : GameBoardUI
    {
        List<Control> PanelsToClear;

        public event EventHandler OnShipSet;
        public ZeeslagLib.Ship ShipToSet { get; set; }

        public GameBoardUIHover()
        {
            InitializeComponent();

            foreach(Panel p in this.tableLayoutPanel1.Controls)
            {
                p.MouseEnter += p_MouseEnter;
                p.MouseLeave += p_MouseLeave;
                p.Click += p_Click;
            }
        }

        void p_Click(object sender, EventArgs e)
        {
            if (PanelsToClear != null)
            {
                PanelsToClear = null;
                var s = ShipToSet;
                s.x = tableLayoutPanel1.GetCellPosition(sender as Control).Column;
                s.y = tableLayoutPanel1.GetCellPosition(sender as Control).Row;
                ShipToSet = null;
                if (OnShipSet != null)
                    OnShipSet(s, new EventArgs());
            }
        }

        void p_MouseLeave(object sender, EventArgs e)
        {
            if(PanelsToClear != null)
                PanelsToClear.ForEach(c => c.BackColor = Color.LawnGreen);
        }

        void p_MouseEnter(object sender, EventArgs e)
        {
            if (ShipToSet == null)
                return;

            PanelsToClear = new List<Control>();

            var pos = tableLayoutPanel1.GetCellPosition(sender as Control);
            for(int i=0;i<ShipToSet.afmeting;i++)
            {
                if (ShipToSet.position == "horizontaal" && pos.Column + i < 10)
                {
                    var p = tableLayoutPanel1.GetControlFromPosition(pos.Column + i, pos.Row);
                    if (p.BackColor == Color.LawnGreen)
                    {
                        PanelsToClear.Add(p);
                    }
                }
                else if (ShipToSet.position == "verticaal" && pos.Row + i < 10)
                {
                    var p = tableLayoutPanel1.GetControlFromPosition(pos.Column, pos.Row + i);
                    if (p.BackColor == Color.LawnGreen)
                    {
                        PanelsToClear.Add(p);
                    }
                }
            }

            if (PanelsToClear.Count == ShipToSet.afmeting)
                PanelsToClear.ForEach(c => c.BackColor = Color.Black);


        }


    }
}
