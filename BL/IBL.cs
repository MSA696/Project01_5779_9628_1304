using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    interface IBL
    {
        void addTester(Tester a);
        void deleteTester(Tester a);
        Tester updateTester(Tester a); //not sure about the recive and returned parameters

        void addTrainee(Trainee a);
        void deleteTrainee(Trainee a);
        Trainee updateTrainee(Trainee a); //not sure about the recive and returned parameters

        void addTest(Test a);
        Test updateTest(Test a); //not sure about the recive and returned parameters

        void getTesters(List<Tester> a);
        void getTrainees(List<Trainee> a);
        void getTests(List<Test> a);
    }
}
