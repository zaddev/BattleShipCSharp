using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeeslagForm
{
    public partial class GameScreen : Form
    {
        private ZeeslagLib.Game game;

        public GameScreen()
        {
            InitializeComponent();
        }

        void game_OnTurn(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                gameBoardUIOpponent.Clickable = (bool)sender;

                if (!(bool)sender)
                    gameBoardUIOpponent.lastPanel.BackColor = game.IsMissed ? Color.Gray : Color.Red;
                else
                {
                    Panel p = gameBoardUIOwn.GetPanel(game.OpponentShoot);
                    if (p.BackColor == Color.Black)
                        p.BackColor = Color.Red;
                    else
                        p.BackColor = Color.Gray;
                }

                label.Text = (bool)sender ? "u bent aan de beurt" : "uw tegenstander is aan de beurt";




            });
        }



        public GameScreen(ZeeslagLib.Game game):this()
        {
            this.game = game;

            game.OnTurn += game_OnTurn;
            gameBoardUIOpponent.Game = game;

            gameBoardUIOwn.PlaceShips(game.Ships);

            if (game.Isturn)
                gameBoardUIOpponent.Clickable = true;

            label.Text = game.Isturn ? "u bent aan de beurt" : "uw tegenstander is aan de beurt";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
