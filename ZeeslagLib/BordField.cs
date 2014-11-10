using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeeslagLib
{
    public class BoardField
    {
        public event EventHandler OnStatusChange;
    
        public BordFieldStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Ship Ship
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
