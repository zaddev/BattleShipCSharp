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
        int currentShip = 0;

        public StartScreen()
        {
            InitializeComponent();

            game = new Game();
            game.OnNewShips += game_OnNewShips;
            game.GameStart += game_GameStart;
            game.StartGame();
            gameBoardUIHover1.OnShipSet += gameBoardUIHover1_OnShipSet;
        }

        void gameBoardUIHover1_OnShipSet(object sender, EventArgs e)
        {
            currentShip++;
            if (currentShip < Ships.Length)
            {
                gameBoardUIHover1.ShipToSet = Ships[currentShip];
                gameBoardUIHover1.ShipToSet.Direction = "horizontaal";
                HorizontaalRadio.Checked = true;
            }
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
            Invoke((MethodInvoker) delegate {
                Ships = sender as Ship[];
                gameBoardUIHover1.ShipToSet = Ships[currentShip];
            });
            
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsScreen();
            settings.Show();
        }

        private void buttonSaveShip_Click(object sender, EventArgs e)
        {
            game.SendShips(Ships);
        }

        private void HorizontaalRadio_CheckedChanged(object sender, EventArgs e)
        {
            gameBoardUIHover1.ShipToSet.Direction = HorizontaalRadio.Checked ? "horizontaal" : "verticaal";
        }
    }
}
