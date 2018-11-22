using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        static int testId = Configuration.firstNum;
        string testerId;
        string traineeId;
        string testDate;
        string dateAndHour; //the time for a test is always 1 hour
        string testAddress;
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
        Test()
        {

        }
    }
}
