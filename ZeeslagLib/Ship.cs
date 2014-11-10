using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeeslagLib
{
    public class Ship
    {
        public event EventHandler OnShipFound;
    
        public Byte Length
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Direction Direction
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public int StartPosition
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
