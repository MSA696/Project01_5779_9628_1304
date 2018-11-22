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
        //ToDo: 1.Make sure that Dal layer is the only one approche DS
        // 2. Make check if ID dosen't excicits
        // 3. DAL layer adds to Test the testId

        /*  Tester addTester()
          {

          }
          void deleteTester()
          {

          }
          Tester setTester()
          {

          }

          Trainee addTrainee()
          {

          }
          void deleteTrainee() { }
          Trainee setTrainee() { }

          Test addTest()
          {
              code++;
          }
          Test setTest() { }

          List<Tester> getTesters() { }
          List<Trainee> getTrainees() { }
          List<Test> getTests() { }*/
        //the one up ^ is our coding
        // ---WE NEED TO DECIDE WHICH ONE TO USE
        //the one down V is the auto-complete coding
        void Idal.addTest(Test a)
        {
            throw new NotImplementedException();
        }

        void Idal.addTester(Tester a)
        {
            throw new NotImplementedException();
        }

        void Idal.addTrainee(Trainee a)
        {
            throw new NotImplementedException();
        }

        void Idal.deleteTester(Tester a)
        {
            throw new NotImplementedException();
        }

        void Idal.deleteTrainee(Trainee a)
        {
            throw new NotImplementedException();
        }

        void Idal.getTesters(List<Tester> a)
        {
            throw new NotImplementedException();
        }

        void Idal.getTests(List<Test> a)
        {
            throw new NotImplementedException();
        }

        void Idal.getTrainees(List<Trainee> a)
        {
            throw new NotImplementedException();
        }

        Test Idal.updateTest(Test a)
        {
            throw new NotImplementedException();
        }

        Tester Idal.updateTester(Tester a)
        {
            throw new NotImplementedException();
        }

        Trainee Idal.updateTrainee(Trainee a)
        {
            throw new NotImplementedException();
        }
    }
}
