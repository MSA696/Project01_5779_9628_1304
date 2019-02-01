using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace BL
{

    public class BL_imp : IBL
    {
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
            List<Tester> tmp = dal.getTesters();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].id == a.id)
                    throw new Exception("the tester exists");
            }
            dal.addTester(a);
        }

        public void deleteTester(Tester a)
        {
            if (boolFindTester(a.id))
                dal.deleteTester(a);
        }

        public void updateTester(Tester a)
        {
            List<Tester> tmp = dal.getTesters();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].id == a.id)
                    dal.updateTester(a);
            }
        }

        public Tester findTester(int id)
        {
            List<Tester> a = dal.getTesters();
            for (int i = 0; i < a.Count; i++)
                if (a[i].id == id)
                    return a[i];
            throw new InvalidDataException("there is no tester with this id");
        }

        public bool boolFindTester(int id)
        {
            List<Tester> a = dal.getTesters();
            for (int i = 0; i < a.Count; i++)
                if (a[i].id == id)
                    return true;
            return false;
        }

        public void addTrainee(Trainee a)
        {
            List<Trainee> tmp = dal.getTrainees();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].id == a.id)
                    throw new Exception("the trainee exists");
            }
            dal.addTrainee(a);
        }

        public void deleteTrainee(Trainee a)
        {
            if (boolFindTrainee(a.id))
                dal.deleteTrainee(a);
        }

        public void updateTrainee(Trainee a)
        {
            List<Trainee> tmp = dal.getTrainees();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].id == a.id)
                    dal.updateTrainee(a);
            }
        }

        public Trainee findTrainee(int id)
        {
            List<Trainee> a = dal.getTrainees();
            for (int i = 0; i < a.Count; i++)
                if (a[i].id == id)
                    return a[i];
            throw new InvalidDataException("there is no trainee with this id");
        }

        public bool boolFindTrainee(int id)
        {
            List<Trainee> a = dal.getTrainees();
            for (int i = 0; i < a.Count; i++)
                if (a[i].id == id)
                    return true;
            return false;
        }

        public void addTest(Test a)
        {
            List<Test> tmp = dal.getTests();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].testId == a.testId)
                    throw new Exception("the test exists");
            }
            dal.addTest(a);
        }

        public void updateTest(Test a)
        {
            List<Test> tmp = dal.getTests();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].testId == a.testId)
                    dal.updateTest(a);
            }
        }
        public Test findTest(int id)
        {
            List<Test> a = dal.getTests();
            for (int i = 0; i < a.Count; i++)
                if (a[i].testId == id)
                    return a[i];
            throw new InvalidDataException("there is no tester with this id");
        }
        public bool boolFindTest(int id)
        {
            List<Test> a = dal.getTests();
            for (int i = 0; i < a.Count; i++)
                if (a[i].testId == id)
                    return true;
            return false;
        }
        public bool dateTestAvailable(DateTime a, hours h, int id)
        {
            List<Test> list = dal.getTests();
            for (int i = 0; i < list.Count; i++)
                if (list[i].testDate == a && list[i].testHour == h && list[i].traineeId != id)
                    return false;
            return true;
        }

        public Tester findTester(address traineeAddr, int maxDis, DateTime testDate, days testDay, hours testHours, int id, car_Type carType)
        {
            Tester tester = new Tester();
            List<Tester> testers = new List<Tester>();
            List<Tester> tmp = TesterByDistance(traineeAddr, maxDis);
            testers = TesterByDateandtime(testDate, testDay, testHours, id, tmp);
            for (int i = 0; i < testers.Count; i++)
            {
                if (testers[i].carType == carType)
                {
                    return testers[i];
                }
            }
            throw new NotFiniteNumberException("there is no tester available");
        }
        public bool testPass(Test a)
        {
            int i = 0;
            if (a.keepDis == true)
                i++;
            if (a.reversePark == true)
                i++;
            if (a.mirror == true)
                i++;
            if (a.signaling == true)
                i++;
            if (a.lights == true)
                i++;
            if (a.belt == true)
                i++;
            if (a.safetyDrive == true)
                i++;
            if (a.priority == true)
                i++;
            if(i>=7)
            {
                return true;
            }
            return false;
        }
        public Test getTestsToCheck()
        {
            List<Test> tmp = getTests();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].check == false)
                {
                    return tmp[i];
                }
            }
            throw new Exception("Ther is no tests to check.");
        }
        public bool boolGetTestsToCheck()
        {
            List<Test> tmp = getTests();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].check == false)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Tester> getTesters()
        {
            return dal.getTesters();
        }    
            
        public List<Trainee> getTrainees()
        {
            return dal.getTrainees();
        }

        public List<Test> getTests()
        {
            return dal.getTests();
        }

        public List<Tester> TesterByDistance(address traineeAddr, int maxDis)
        {
            List<Tester> list = dal.getTesters();
            List<Tester> tmp = new List<Tester>();
            for (int i = 0; i < list.Count; i++)
            {
                if (checkDis(traineeAddr, list[i].addr) < maxDis)
                    tmp.Add(list[i]);
            }
            return tmp;
        }

        public List<Tester> TesterByDateandtime(DateTime testDate, days testDay, hours testHour, int id,List<Tester> list)
        {
            List<Tester> tmp = new List<Tester>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].workHour[Convert.ToInt32(testDay) , Convert.ToInt32(testHour)])
                    if(dateTestAvailable(testDate, testHour, id))
                        tmp.Add(list[i]);
            }
            return tmp;
        }

        public List<Test> TestByCondition(Func<Test, bool> cond = null)
        {
            List<Test> list = dal.getTests();
            if (cond != null)
                list = list.Where(cond).ToList();
            return list;
        }

        public int checkDis(address a, address b)
        {
            string origin = (a.street + a.building + a.city).ToString();
            string destination = (b.street + b.building + b.city).ToString();
            string KEY = @"RimGTAFNgGAaEAUJWHIEXhlXc07qnMG0";
            string url = @"https://www.mapquestapi.com/directions/v2/route" +
            @"?key=" + KEY +
            @"&from=" + origin +
            @"&to=" + destination +
            @"&outFormat=xml" +
            @"&ambiguities=ignore&routeType=fastest&doReverseGeocode=false" +
            @"&enhancedNarrative=false&avoidTimedConditions=false";
            //request from MapQuest service the distance between the 2 addresses
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            //the response is given in an XML format
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);
            if (xmldoc.GetElementsByTagName("statusCode")[0].ChildNodes[0].InnerText == "0")
            //we have the expected answer
            {
                //display the returned distance
                XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
                double distInMiles = Convert.ToDouble(distance[0].ChildNodes[0].InnerText);
                //Console.WriteLine("Distance In KM: " + distInMiles * 1.609344);
                //display the returned driving time
                XmlNodeList formattedTime = xmldoc.GetElementsByTagName("formattedTime");
                string fTime = formattedTime[0].ChildNodes[0].InnerText;
                //Console.WriteLine("Driving Time: " + fTime);

                return Convert.ToInt32(distInMiles * 1.609344);
            }
            else if (xmldoc.GetElementsByTagName("statusCode")[0].ChildNodes[0].InnerText == "402")
            //we have an answer that an error occurred, one of the addresses is not found
            {
                //Console.WriteLine("an error occurred, one of the addresses is not found. try again.");
                return 10;
                throw new InvalidDataException("one of the addresses is not found");
            }
            else //busy network or other error...
            {
                //Console.WriteLine("We have'nt got an answer, maybe the net is busy...");
                throw new InvalidDataException("We have'nt got an answer");
            }
        }
        
        public int traineeTestCount(Trainee a)
        {
            //return number of tests Trainee did
            return a.testsNum;
        }

        public bool traineeScore(Trainee a)
        {
            List<Test> tmp = getTests();
            for (int i = tmp.Count; i > 0; i--)
            {
                if (tmp[i].traineeId == a.id) return tmp[i].score;
            }
            return false;
        }

        public List<Test> testSortList()
        {
            List<Test> list = dal.getTests();
            list.Sort(compare);
            return list;
        }      
                
        public int compare(Test x, Test y)
        {
            if (x.testDate < y.testDate)
                return -1;
            if (x.testDate == y.testDate)
                return 0;
            else
                return 0;
        }
        
        #endregion
    }
}
