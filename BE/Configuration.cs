using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        static int minClass = 20;
        static int maxTesterAge;
        static int minTesterAge = 40;
        static int minTraineeAge = 18;
        static int TestRange = 7;
        public static int firstNum = 1;
    }
    public struct address
    {
        public string city { get; set; }
        public string street { get; set; }
        public int building { get; set; }
    }
}

