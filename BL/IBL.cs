﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    interface IBL
    {
        void addTester(Tester a);
        void deleteTester(Tester a);
        Tester updateTester(Tester a); //not sure about the recive and returned parameters

        void addTrainee(Trainee a);
        void deleteTrainee(Trainee a);
        Trainee updateTrainee(Trainee a); //not sure about the recive and returned parameters

        void addTest(Test a);
        Test updateTest(Test a); //not sure about the recive and returned parameters

        void getTesters(List<Tester> a);
        void getTrainees(List<Trainee> a);
        void getTests(List<Test> a);
        List<Tester> TesterByDistance(address a);
        List<Tester> TesterByDateandtime(DateTime a);
        //didn't understand the demand "kol ha'mivhanim"
        int traineeTestCount(Trainee a);
        bool traineeScore(Trainee a);
        List<Test> testSortList();
        //next func are by Grouping method - we have an Exmple in main !
        //  List of Testers by specialization type
        //  List of Trainee by driving school
        //  List of Trainee by driving teacher
        //  List of Trainee by number of tests
    }
}