using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using System.Diagnostics;

namespace ZeeslagLib
{
    public class Game
    {
        public event EventHandler OnActivePlayerChange;
        private Socket socket;

        public Ship[] Ships { get; set; }
        public event EventHandler OnNewShips;

        public Game()
        {
            BattleShipSettings.OnConnectionURLChange += BattleShipSettings_OnConnectionURLChange;
        }

        void BattleShipSettings_OnConnectionURLChange(object sender, EventArgs e)
        {
            if (socket != null)
            {
                socket.Disconnect();
                throw new Exception("Connection has closed");
            }
        }

        /// <summary>
        /// er wordt verbinding gemaakt met de server.
        /// </summary>
        public void StartGame()
        {
            socket = IO.Socket(BattleShipSettings.ConnectionURL);

            socket.On("getSchepen", GetSchepen);
        }

        private void GetSchepen(object o)
        {
            var array = o as Newtonsoft.Json.Linq.JArray;
            array = array[0] as Newtonsoft.Json.Linq.JArray;

            Ships = array.ToObject<Ship[]>();

            if (OnNewShips != null)
            {
                //alleen tijdens debug
                this.shipsSetTestValues(Ships);

                OnNewShips(Ships, new EventArgs());
            }
        }

        [ConditionalAttribute("DEBUG")]
        private void shipsSetTestValues(Ship[] ships)
        {
            try
            {
                string h = "horizontaal";
                string v = "verticaal";

                int i = 0;
                ships[i].position = h;
                ships[i].x = 4;
                ships[i].y = 9;
                i++;
                ships[i].position = h;
                ships[i].x = 6;
                ships[i].y = 0;
                i++;
                ships[i].position = v;
                ships[i].x = 0;
                ships[i].y = 2;
                i++;
                ships[i].position = v;
                ships[i].x = 3;
                ships[i].y = 0;
                i++;
                ships[i].position = h;
                ships[i].x = 5;
                ships[i].y = 2;
                i++;
                ships[i].position = v;
                ships[i].x = 9;
                ships[i].y = 5;
                i++;
                ships[i].position = h;
                ships[i].x = 2;
                ships[i].y = 4;
                i++;
                ships[i].position = v;
                ships[i].x = 3;
                ships[i].y = 6;
                i++;
                ships[i].position = h;
                ships[i].x = 0;
                ships[i].y = 9;
                i++;
                ships[i].position = h;
                ships[i].x = 0;
                ships[i].y = 0;
                i++;
                ships[i].position = v;
                ships[i].x = 9;
                ships[i].y = 2;
                i++;
                ships[i].position = v;
                ships[i].x = 5;
                ships[i].y = 5;
                i++;
                ships[i].position = h;
                ships[i].x = 0;
                ships[i].y = 7;

            }
            catch (ArgumentOutOfRangeException aore)
            { }
        }

        public bool CloseConnection()
        {
            if (socket == null)
                return false;

            socket.Close();
            return true;
        }

        public void SendShips(Ship[] ships)
        {
            if (ships == null)
                throw new ArgumentNullException("ships");

            socket.On("turn", GameRealStart);
            socket.On("wait", GameRealStart);

            socket.Emit("setSchepen", JsonConvert.SerializeObject(ships, Formatting.Indented));  
        }

        public event EventHandler GameStart;
        private bool started = false;

        private void GameRealStart(object obj)
        {
            if (!started)
                if (GameStart != null)
                    GameStart(null, null);
        }
    }
}
