using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;

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
                OnNewShips(Ships, new EventArgs());
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

            socket.Emit("setSchepen", JsonConvert.SerializeObject(ships, Formatting.Indented));  
        }
    }
}
