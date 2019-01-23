﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime birth { get; set; }
        public _gender gender { get; set; }
        public string phone { get; set; }
        public address addr { get; set; }
        public car_Type carType { get; set; }
        public gear_Box gearBox { get; set; }
        public school_Name schoolName { get; set; }
        public string teacher { get; set; }
        public int classNum { get; set; }
        public int maxDis { get; set; }
        public Tester myTester { get; set; }
        //another properties by demand
        public int testsNum { get; set; }
        public days testDey { get; set; }
        public hours testHour { get; set; }
        public Trainee()
        {
            testsNum = 0;
        }
        override public string ToString()
        {
            return "";//assumption: returns any property of class as String
        }
    }
}
