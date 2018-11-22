using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        int id;
        string lastName;
        string firstName;
        string birth;
        string gender;
        string phone;
        string address;
        string carType;
        string gearBox;
        string schoolName;
        string teacher;
        int classNum;
        //another properties by demand
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
