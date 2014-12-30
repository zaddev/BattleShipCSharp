using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeeslagLib;

namespace ZeeslagForm
{
    public partial class ShipSettingsControl : UserControl
    {
        Ship ship;
        public Ship Ship
        {
            get
            {
                ship.Name = textBoxName.Text;
                ship.X = int.Parse(textBoxX.Text);
                ship.Y = int.Parse(textBoxY.Text);
                //ship.afmeting = textBoxLength.Text;
                ship.Direction = comboBoxDirection.Text;

                return ship;
            }
        }

        public ShipSettingsControl()
        {
            InitializeComponent();
        }

        public ShipSettingsControl(Ship ship) : this()
        {
            this.ship = ship;

            this.textBoxName.Text = ship.Name;
            this.textBoxX.Text = ship.X.ToString();
            this.textBoxY.Text = ship.Y.ToString();
            this.textBoxLength.Text = ship.Length.ToString();
            this.comboBoxDirection.Text = ship.Direction;
        }


    }
}
