using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeeslagLib
{
    public class Game
    {
        public event EventHandler OnActivePlayerChange;
    
        public Player[] Players
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Player ActivePlayer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    }
}
