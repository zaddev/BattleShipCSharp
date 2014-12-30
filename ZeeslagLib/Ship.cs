using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ZeeslagLib
{
    [DataContract]
    public class Ship
    {
        [DataMember(Name="afmeting")]
        public int Length { get; set; }
        [DataMember(Name = "naam")]
        public string Name { get; set; }
        [DataMember(Name = "x")]
        public int X { get; set; }
        [DataMember(Name = "y")]
        public int Y { get; set; }

        [DataMember(Name = "position")]
        public string Direction { get; set; }
    }
}
