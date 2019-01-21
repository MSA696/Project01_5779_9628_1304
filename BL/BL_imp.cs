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

namespace BL
{
    
    public class BL_imp: IBL
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
            return dal.getTesters();
        }        
        public List<Trainee> getTrainees()
        {
            return dal.getTrainees();
        }

        public List<Test> getTests()
        {
            return getTests();
        }

        public List<Tester> TesterByDistance(address a)
        {
            string origin = "menahem begin 111 ave. kiryat shmona"; //or " אחד העם 100 פתח תקווה " etc.
            string destination = "yoni netanyahu 1013, kiryat arba";//or " ז'בוטינסקי 10 רמת גן " etc.
            string KEY = @"CpK0KMZhQe3Utqow8JwT6Py9pZApvr9l";
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
                Console.WriteLine("Distance In KM: " + distInMiles * 1.609344);
                //display the returned driving time
                XmlNodeList formattedTime = xmldoc.GetElementsByTagName("formattedTime");
                string fTime = formattedTime[0].ChildNodes[0].InnerText;
                Console.WriteLine("Driving Time: " + fTime);
            }
            else if (xmldoc.GetElementsByTagName("statusCode")[0].ChildNodes[0].InnerText == "402")
            //we have an answer that an error occurred, one of the addresses is not found
            {
                Console.WriteLine("an error occurred, one of the addresses is not found. try again.");
            }
            else //busy network or other error...
            {
                Console.WriteLine("We have'nt got an answer, maybe the net is busy...");
            }
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
        public Tester FindTester(List<Tester> a, List<Tester> b)
        {
            throw new NotImplementedException();
        }
        public int traineeTestCount(Trainee a)
        {
            //return number of tests Trainee did
            return a.TestsNum;           //צריך לדאוג: א'-לאפס את השדה ביצירת התלמיד. ב'-שבכל פעם שמייצרים (בהצלחה) טסט לתלמיד להגדיל את הערך הזה ב1
        }
        public bool traineeScore(Trainee a)
        {
            List<Test> tmp = getTests();
            for (int i = tmp.Count; i > 0; i--)
            {
                if (tmp[i].traineeId == a.id) return tmp[i].score;
            }
            throw new Exception(); //צריך לעשות כאן חריגה שעוברת ליו.איי. ומודיע לה שלא נמצא מבחן שעשה התלמיד הנ"ל
        }
        public List<Test> testSortList()
        {
            //return list of all tests sorted by day/month
            throw new NotImplementedException();
        }      
                
        #endregion
    }
}
