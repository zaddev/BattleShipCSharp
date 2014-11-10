using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeeslagLib
{
    public abstract class Ship
    {
        public event EventHandler OnShipFound;

        public abstract Byte Length { get; }
        public abstract string Name { get; } 

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

        

        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// each player have one
    /// </summary>
    public class AicraftCarrier : Ship
    {
        public override byte Length
        {
            get { return 5; }
        }

        public override string Name
        {
            get { return "aircraft Carrier"; }
        }
    }

    /// <summary>
    /// each players has two
    /// </summary>
    public class BattleShip : Ship
    {
        public override byte Length
        {
            get { return 4; }
        }

        public override string Name
        {
            get { return "battle ship"; }
        }
    }

    /// <summary>
    /// each player has three
    /// </summary>
    public class SubMarine : Ship
    {
        public override byte Length
        {
            get { return 3; }
        }

        public override string Name
        {
            get { return "submarine"; }
        }
    }

    /// <summary>
    /// each player has three
    /// </summary>
    public class Destroyer : Ship
    {
        public override byte Length
        {
            get { return 3; }
        }

        public override string Name
        {
            get { return "destroyer"; }
        }
    }

    /// <summary>
    /// each player has four
    /// </summary>
    public class PatrolBoat : Ship
    {
        public override byte Length
        {
            get { return 2; }
        }

        public override string Name
        {
            get { return "patrol boat"; }
        }
    }
}
