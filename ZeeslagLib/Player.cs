using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeeslagLib
{
    public class Player
    {
        public event EventHandler OnSet;
    
        public Board Board
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public bool IsOnSet
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Board OpponentBoard
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Ship[] OwnShips
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
