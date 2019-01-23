using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        void addTester(Tester a);
        void deleteTester(Tester a);
        Tester updateTester(Tester a); //not sure about the recive and returned parameters
        Tester findTester(int id);

        void addTrainee(Trainee a);
        void deleteTrainee(Trainee a);
        Trainee updateTrainee(Trainee a); //not sure about the recive and returned parameters
        Trainee findTrainee(int id);

        void addTest(Test a);
        Test updateTest(Test a); //not sure about the recive and returned parameters
        bool dateTestAvailable(DateTime a);

        List<Tester> getTesters();
        List<Trainee> getTrainees();
        List<Test> getTests(); 

        List<Tester> TesterByDistance(address traineeAddr, int maxDis);
        List<Tester> TesterByDateandtime(DateTime testDate, days testDay ,hours testHours , List<Tester> list);
        bool TestByCondition(Delegate a);//<--!!didn't understand the demand "kol ha'mivhanim"
        int checkDis(address a, address b);

        int traineeTestCount(Trainee a);
        bool traineeScore(Trainee a);
        List<Test> testSortList();  //do here sort of the list by DateAndTime of Tests
        //next func are by Grouping method - we have an Exmple in main !
        //  List of Testers by specialization type
        //  List of Trainee by driving school
        //  List of Trainee by driving teacher
        //  List of Trainee by number of tests
    }
}
