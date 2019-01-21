using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        public Tester() {}
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime birth { get; set; }
        public _gender gender { get; set; }
        public string phone { get; set; }
        public address addr { get; set; }
        public int experience { get; set; }
        public int maxTests { get; set; }
        public car_Type carType { get; set; }
        public school_Name schoolName { get; set; }
        public bool[,] workHour = new bool[5, 6];
        public int maxDist { get; set; }
        //another properties by demand
        public gear_Box gearBox { get; set; }
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
