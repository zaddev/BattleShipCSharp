using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ZeeslagLib
{
    /// <summary>
    /// all configuration settings for the Battleship game
    /// </summary>
    public static class BattleShipSettings
    {
        /// <summary>
        /// triggers when ConnectionURL change
        /// </summary>
        public static event EventHandler OnConnectionURLChange;

        /// <summary>
        /// url where the node server is hosting
        /// </summary>
        public static string ConnectionURL
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ConnectionURL"]; }
            set
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["ConnectionURL"].Value = value;
                if(OnConnectionURLChange!=null)D:\data barld\Documents\BattleShipCSharp\ZeeslagLib\BattleShipSettings.cs
                    OnConnectionURLChange(value, new EventArgs());

                //save to apply changes
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }
    }
}
