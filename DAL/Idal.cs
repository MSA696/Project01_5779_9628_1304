﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
   public interface Idal
    {
        
        void addTester(Tester a);
        void deleteTester(Tester a);
        void updateTester(Tester a); //not sure about the recive and returned parameters


        void addTrainee(Trainee a);
        void deleteTrainee(Trainee a);
        void updateTrainee(Trainee a); //not sure about the recive and returned parameters

        void addTest(Test a);
        void updateTest(Test a); //not sure about the recive and returned parameters
        void addTestId(Test a, int id);

        List<Tester> getTesters();
        List<Trainee> getTrainees();
        List<Test> getTests();
    }
}
