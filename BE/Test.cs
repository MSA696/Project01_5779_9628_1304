using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        int testId;
        public int _testId { set { testId = value; } get { return testId; } }   // sure this is the method to configure the "testId"? how we implement the run-number?
        int testerId;
        public int _testerId { set { testerId = value; } get { return testerId; } }
        int traineeId;
        public int _traineeId { set { traineeId = value; } get { return traineeId; } }
        DateTime testDate;
        string dateAndHour; //the time for a test is always 1 hour
        address beginOfTestAdr;
        bool keepDis;
        bool reversePark;
        bool mirror;
        bool signaling;
        bool score;
        string note;
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
        public Test()
        {
            
        }
    }
}
