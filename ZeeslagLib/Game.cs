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
                ships[i].Direction = h;
                ships[i].X = 4;
                ships[i].Y = 9;
                i++;
                ships[i].Direction = h;
                ships[i].X = 6;
                ships[i].Y = 0;
                i++;
                ships[i].Direction = v;
                ships[i].X = 0;
                ships[i].Y = 2;
                i++;
                ships[i].Direction = v;
                ships[i].X = 3;
                ships[i].Y = 0;
                i++;
                ships[i].Direction = h;
                ships[i].X = 5;
                ships[i].Y = 2;
                i++;
                ships[i].Direction = v;
                ships[i].X = 9;
                ships[i].Y = 5;
                i++;
                ships[i].Direction = h;
                ships[i].X = 2;
                ships[i].Y = 4;
                i++;
                ships[i].Direction = v;
                ships[i].X = 3;
                ships[i].Y = 6;
                i++;
                ships[i].Direction = h;
                ships[i].X = 0;
                ships[i].Y = 9;
                i++;
                ships[i].Direction = h;
                ships[i].X = 0;
                ships[i].Y = 0;
                i++;
                ships[i].Direction = v;
                ships[i].X = 9;
                ships[i].Y = 2;
                i++;
                ships[i].Direction = v;
                ships[i].X = 5;
                ships[i].Y = 5;
                i++;
                ships[i].Direction = h;
                ships[i].X = 0;
                ships[i].Y = 7;

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

            socket.On("turn", turn);
            socket.On("wait", wait);

            socket.Emit("setSchepen", JsonConvert.SerializeObject(ships, Formatting.Indented));  
        }

        public bool IsWait { get { return !Isturn; } }

        public bool IsMissed { get; private set; }
        private void wait(object obj)
        {
            if(obj != null)
                IsMissed = obj.ToString() == "missed";
            Isturn = false;

            if (!started)
                GameRealStart();
        }

        public event EventHandler OnTurn;
        bool isturn = false;
        public bool Isturn
        {
            get { return isturn; }
            set
            {
                isturn = value;
                if (OnTurn != null)
                    OnTurn(value, null);
            }
        }

        public int[] OpponentShoot { get; set; }

        private void turn(object obj)
        {
            if(obj != null)
                OpponentShoot = new int[] { (int)(obj as Newtonsoft.Json.Linq.JArray)[1], (int)(obj as Newtonsoft.Json.Linq.JArray)[0]};
            Isturn = true;

            if (!started)
                GameRealStart();

        }

        public event EventHandler GameStart;
        private bool started = false;

        private void GameRealStart()
        {
            if (!started && GameStart != null)
                GameStart(null, null);

            started = true;
        }

        public void Shoot(int[] p)
        {
            socket.Emit("setShoot", JsonConvert.SerializeObject(p));
        }
    }
}
