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
        void Idal.addTest(Test b)
        {
            Test a = new Test();
            a._testId = Configuration.firstNum;
            Console.WriteLine("tester id");
            Console.ReadLine((a._testerId));//int type
            Configuration.firstNum++;
            DataSouce.tests.Add(a);
            //...
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
        }

        void Idal.deleteTrainee(Trainee a)
        {
            DataSouce.trainees.Remove(a);
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
