using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        int id;
        string lastName;
        public string _lastName { get { return lastName; } set { lastName = value; } }
        string firstName;
        string birth;
        _gender gender;
        string phone;
        address adr;
        int experience;
        int maxTests;
        car_Type carType;
        bool[,] workHour = new bool[5, 6];
        int maxDist;
        //another properties by demand
        gear_Box gearBox;
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
