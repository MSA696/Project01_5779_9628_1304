using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : Idal
    {
        public  List<Test> tests = new List<Test>();
        public  List<Tester> testers = new List<Tester>();
        public  List<Trainee> trainees = new List<Trainee>();
        void Idal.addTest(Test b)
        {
            b._testId = Configuration.firstNum; 
            Configuration.firstNum++;
            tests.Add(b);
        }

        void Idal.addTester(Tester a)
        {
            DataSouce.testers.Add(a);
        }

        void Idal.addTrainee(Trainee a)
        {
            DataSouce.trainees.Add(a);
        }

        void Idal.deleteTester(Tester a)
        {
            DataSouce.testers.Remove(a);
            //make sure id of removed tester is no longer exsit
        }

        void Idal.deleteTrainee(Trainee a)
        {
            DataSouce.trainees.Remove(a);
            //make sure id of removed trainee is no longer exsit
        }

        void Idal.getTesters(List<Tester> a)
        {
            foreach (var el in DataSouce.testers)
                Console.WriteLine(el);
        }

        void Idal.getTests(List<Test> a)
        {
            foreach (var el in DataSouce.tests)
                Console.WriteLine(el);
        }

        void Idal.getTrainees(List<Trainee> a)
        {
            foreach (var el in DataSouce.trainees)
                Console.WriteLine(el);
        }

        void Idal.updateTest(Test a)
        {
            //int index = DataSouce.tests.BinarySearch(a);
            //DataSouce.tests[index].
        }

        void Idal.updateTester(Tester a)
        {
            //int index = DataSouce.testers.BinarySearch(a);
            //DataSouce.tests[index].
        }

        void Idal.updateTrainee(Trainee a)
        {
            //int index = DataSouce.trainees.BinarySearch(a);
            //DataSouce.tests[index].
        }
    }
}
