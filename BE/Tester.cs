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
        string lastName; //{ get; set;}
        string firstName;
        string birth;
        string gender;
        string phone;
        string address;
        int experience;
        int maxTests;
        string carType;
        bool[,] workHour = new bool[5, 6];
        int maxDist;
        //another properties by demand
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
