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
            gameBoardUIOpponent.Clickable = true;
        }



        public GameScreen(ZeeslagLib.Game game):this()
        {
            this.game = game;

            game.OnTurn += game_OnTurn;
            gameBoardUIOpponent.Game = game;

            gameBoardUIOwn.PlaceShips(game.Ships);

            if (game.Isturn)
                gameBoardUIOpponent.Clickable = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
