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
        void updateTester(Tester a); //not sure about the recive and returned parameters
        Tester findTester(int id);
        bool boolFindTester(int id);

        void addTrainee(Trainee a);
        void deleteTrainee(Trainee a);
        void updateTrainee(Trainee a); //not sure about the recive and returned parameters
        Trainee findTrainee(int id);
        bool boolFindTrainee(int id);

        void addTest(Test a);
        void updateTest(Test a); //not sure about the recive and returned parameters
        bool dateTestAvailable(DateTime a, hours h, int id);
        Test findTest(int id);
        bool boolFindTest(int id);
        Test getTestsToCheck();
        bool boolGetTestsToCheck();
        bool testPass(Test a);


        List<Tester> getTesters();
        List<Trainee> getTrainees();
        List<Test> getTests(); 

        List<Tester> TesterByDistance(address traineeAddr, int maxDis);
        List<Tester> TesterByDateandtime(DateTime testDate, days testDay ,hours testHours, int id , List<Tester> list);
        Tester findTester(address traineeAddr, int maxDis, DateTime testDate, days testDay, hours testHours, int id, car_Type carType);

        List<Test> TestByCondition(Func<Test, bool> predicate = null);
        int checkDis(address a, address b);

        int traineeTestCount(Trainee a);
        bool traineeScore(Trainee a);
        List<Test> testSortList();  //do here sort of the list by DateAndTime of Tests
        int compare(Test x, Test y);
        //next func are by Grouping method - we have an Exmple in main !
        //  List of Testers by specialization type
        //  List of Trainee by driving school
        //  List of Trainee by driving teacher
        //  List of Trainee by number of tests
    }
}
