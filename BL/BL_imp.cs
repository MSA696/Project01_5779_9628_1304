using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    
    public class BL_imp: IBL
    {
        Dal_imp _DAL = new Dal_imp();
        public void addTest(Test a)
        {
            //no option to add test if 7 days didn't past from trainee's last test implementation
            //no option to add test if did less then 20 drive-classes implementation
            /*no option to add test if there is no available Tester for the date requested implementation
              in this case- the system can offer alternate date for test*/
            //no option to add testerId to test if Tester's maxWeeklyTests is reached implementation
            //make sure there isn't two tests in the same time for the same trainee/tester. 
            //no option to add test if trainee already succesfuly passed test in same carType implementation
            //make sure to fit tester to trainee by carType
            _DAL.addTest(a);
        }

        public void addTester(Tester a)
        {
            //no option to add tester above MaxAge implementation
            _DAL.addTester(a);
        }

        public void addTrainee(Trainee a)
        {
            //no option to add trainee beneath MinAge implementation
            _DAL.addTrainee(a);
        }

        public void deleteTester(Tester a)
        {
            _DAL.deleteTester(a);
        }

        public void deleteTrainee(Trainee a)
        {
            _DAL.deleteTrainee(a);
        }

        public void getTesters(List<Tester> a)
        {
            return (_DAL.getTesters());
        }

        public void getTests(List<Test> a)
        {
            throw new NotImplementedException();
        }

        public void getTrainees(List<Trainee> a)
        {
            throw new NotImplementedException();
        }

        public Test updateTest(Test a)
        {
            /*no option to update test if all testers field isn't fill implementation
              notice: need to think how to do it whitout disabling Tester approch to his filled*/
            throw new NotImplementedException();
        }

        public Tester updateTester(Tester a)
        {
            throw new NotImplementedException();
        }

        public Trainee updateTrainee(Trainee a)
        {
            throw new NotImplementedException();
        }
        public List<Tester> TesterByDistance(address a)
        {
            //in later Phase will use WebRequest, for Phase 1 raffle fit number - what's the meaning?
            throw new NotImplementedException();
        }
        public List<Tester> TesterByDateandtime(DateTime a)
        {
            //will check testers that are work and available
            throw new NotImplementedException();
        }
        public int traineeTestCount(Trainee a)
        {
            //return number of tests Trainee did
            throw new NotImplementedException();
        }
        public bool traineeScore(Trainee a)
        {
            throw new NotImplementedException();
        }
        public List<Test> testSortList()
        {
            //return list of all tests sorted by day/month
            throw new NotImplementedException();
        }
    }
}
