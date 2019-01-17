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
        /*DAL.Idal dal;
        dal = DAL.factoryDAL.GetInstance();*/
        #region Singelton
        protected BL_imp() { }
        static BL_imp BLinstance;
        public static BL_imp GetInstance()
        {
            if (BLinstance == null)
                BLinstance = new BL_imp();
            return BLinstance;
        }
        #endregion

        Idal dal = factoryDAL.DALGetInstance();     //Instance to reach DAL Layer

        #region InterfaceImplement
        public void addTester(Tester a)
        {
            //no option to add tester above MaxAge implementation
            dal.addTester(a);
        }
        public void deleteTester(Tester a)
        {
            dal.deleteTester(a);
        }
        public Tester updateTester(Tester a)
        {
            throw new NotImplementedException();
        }

        public void addTrainee(Trainee a)
        {
            //no option to add trainee beneath MinAge implementation
            dal.addTrainee(a);
        }
        public void deleteTrainee(Trainee a)
        {
            dal.deleteTrainee(a);
        }
        public Trainee updateTrainee(Trainee a)
        {
            throw new NotImplementedException();
        }

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
            dal.addTest(a);
        }
        public Test updateTest(Test a)
        {
            /*no option to update test if all testers field isn't fill implementation
              notice: need to think how to do it whitout disabling Tester approch to his filled*/
            throw new NotImplementedException();
        }

        public List<Tester> getTesters()
        {
            //return (_DAL.getTesters());
            throw new NotImplementedException();
        }        
        public List<Trainee> getTrainees()
        {
            throw new NotImplementedException();
        }

        public List<Test> getTests()
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
        public bool TestByCondition(Delegate a)
        {
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
                
        #endregion
    }
}
