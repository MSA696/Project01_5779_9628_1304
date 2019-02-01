using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        public Test(){}
        public int testId { get; set; }
        public int testerId { get; set; }
        public int traineeId { get; set; }
        public DateTime testDate { get; set; }  //by trainee input
        //public DateTime dateAndHour { get; set; } //the time for a test is always 1 hour
        public days testDay { get; set; }
        public hours testHour { get; set; }
        public address beginOfTestAdr;    //by trainee input
        public bool keepDis { get; set; }
        public bool reversePark { get; set; }
        public bool mirror { get; set; }
        public bool signaling { get; set; }
        public bool lights { get; set; }
        public bool belt { get; set; }
        public bool safetyDrive { get; set; }
        public bool priority { get; set; }
        public bool score { get; set; }
        public bool check { get; set; }
        public string note { get; set; }
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
