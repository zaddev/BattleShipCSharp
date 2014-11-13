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
                ship.naam = textBoxName.Text;
                ship.x = int.Parse(textBoxX.Text);
                ship.y = int.Parse(textBoxY.Text);
                //ship.afmeting = textBoxLength.Text;
                ship.position = comboBoxDirection.Text;

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

            this.textBoxName.Text = ship.naam;
            this.textBoxX.Text = ship.x.ToString();
            this.textBoxY.Text = ship.y.ToString();
            this.textBoxLength.Text = ship.afmeting.ToString();
        }


    }
}
