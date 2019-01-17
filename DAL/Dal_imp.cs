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

        internal Dal_imp() { }

        static Dal_imp DALinstance=null;
        public static Dal_imp GetInstance()
        {
            if (DALinstance == null)
                DALinstance = new Dal_imp();
            return DALinstance;
        }

        #region Function
        public void addTest(Test a)
        {
            try
            {
                if (tests.Contains(a))
                {
                    //throw new Exception
                }
                a._testId = Configuration.firstNum;
                Configuration.firstNum++;
                tests.Add(a);
            }
            catch (Exception)
            {
                Console.WriteLine("The Test exist ");
            }
        }

        public void addTester(Tester a)
        {
            try
            {
                if (testers.Contains(a))
                {
                    //throw new Exception
                }
                testers.Add(a);
            }
            catch (Exception)
            {
                Console.WriteLine("The Tester exist ");
            }
        }

        public void addTrainee(Trainee a)
        {
            try
            {
                if (trainees.Contains(a))
                {
                    //throw new Exception
                }
                trainees.Add(a);
            }
            catch (Exception)
            {
                Console.WriteLine("The Tester exist ");
            }
        }

        public void deleteTester(Tester a)
        {
            testers.Remove(a);
            //make sure id of removed tester is no longer exsit
        }

        public void deleteTrainee(Trainee a)
        {
            trainees.Remove(a);
            //make sure id of removed trainee is no longer exsit
        }

        public List<Tester> getTesters()
        {
            return testers;
        }

        public List<Test> getTests()
        {
            return tests;
        }

        public List<Trainee> getTrainees()
        {
            return trainees;
        }

        public void updateTest(Test a)
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

        public void updateTester(Tester a)
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

        public void updateTrainee(Trainee a)
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
        #endregion
    }
}
