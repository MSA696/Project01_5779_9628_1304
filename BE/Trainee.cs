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
        public int _traineeId { set { id = value; } get { return id; } }
        string lastName;
        string firstName;
        string birth;
        _gender gender;
        string phone;
        address adr;
        car_Type carType;
        gear_Box gearBox;
        school_Name schoolName;
        string teacher;
        int classNum;
        //another properties by demand
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
