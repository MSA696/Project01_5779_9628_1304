using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Dal_imp : Idal
    {
        public  List<Test> tests = new List<Test>();
        public  List<Tester> testers = new List<Tester>();
        public  List<Trainee> trainees = new List<Trainee>();
        void Idal.addTest(Test a)
        {
            a._testId = Configuration.firstNum; 
            Configuration.firstNum++;
            tests.Add(a);
        }

        void Idal.addTester(Tester a)
        {
            testers.Add(a);
        }

        void Idal.addTrainee(Trainee a)
        {
            trainees.Add(a);
        }

        void Idal.deleteTester(Tester a)
        {
            testers.Remove(a);
            //make sure id of removed tester is no longer exsit
        }

        void Idal.deleteTrainee(Trainee a)
        {
            trainees.Remove(a);
            //make sure id of removed trainee is no longer exsit
        }

        void Idal.getTesters(List<Tester> a)
        {
            foreach (var el in testers)
                Console.WriteLine(el);
        }

        void Idal.getTests(List<Test> a)
        {
            foreach (var el in tests)
                Console.WriteLine(el);
        }

        void Idal.getTrainees(List<Trainee> a)
        {
            foreach (var el in trainees)
                Console.WriteLine(el);
        }

        void Idal.updateTest(Test a)
        {
            int index = 0;
            foreach (var el in tests)
            {
                if (el._testId == a._testId)
                    break;
                index++;
            }
            tests[index] = a;
        }

        void Idal.updateTester(Tester a)
        {
            int index = 0;
            foreach (var el in testers)
            {
                if (el._testerId == a._testerId)
                    break;
                index++;
            }
            testers[index] = a;
        }

        void Idal.updateTrainee(Trainee a)
        {
            int index = 0;
            foreach (var el in trainees)
            {
                if (el._traineeId == a._traineeId)
                    break;
                index++;
            }
            trainees[index] = a;
        }
    }
}
