using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        public Test() {}
        public int testId { get; set; }
        public int testerId { get; set; }
        public int traineeId { get; set; }
        public DateTime testDate { get; set; }  //by trainee input
        public DateTime dateAndHour { get; set; } //the time for a test is always 1 hour
        public address beginOfTestAdr { get; set; }     //by trainee input
        public bool keepDis { get; set; }
        public bool reversePark { get; set; }
        public bool mirror { get; set; }
        public bool signaling { get; set; }
        public bool score { get; set; }
        public string note { get; set; }
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
