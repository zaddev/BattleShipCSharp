using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeeslagLib;

namespace ZeeslagForm
{
    public partial class StartScreen : Form
    {
        private Game game;
        Ship[] Ships;

        public StartScreen()
        {
            InitializeComponent();

            game = new Game();
            game.OnNewShips += game_OnNewShips;
            game.GameStart += game_GameStart;
            game.StartGame();
        }

        void game_GameStart(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                new GameScreen(game).Show();
            });
        }

        void game_OnNewShips(object sender, EventArgs e)
        {
            Ships = sender as Ship[];

            Invoke((MethodInvoker) delegate {

                int top = 10;
                foreach (Ship ship in Ships)
                {
                    var settings = new ShipSettingsControl(ship);
                    settings.Top = top;
                    panel1.Controls.Add(settings);
                    settings.Show();

                    top += settings.Height + 15;
                }
            });
            
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsScreen();
            settings.Show();
        }

        private void buttonSaveShip_Click(object sender, EventArgs e)
        {
            List<Ship> listShips = new List<Ship>();
            foreach(ShipSettingsControl ship in panel1.Controls)
            {
                listShips.Add( ship.Ship);
            }

            game.SendShips(listShips.ToArray());
        }
    }
}
