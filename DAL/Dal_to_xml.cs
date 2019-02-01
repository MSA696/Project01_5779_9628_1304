using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace DAL
{
    internal class Dal_to_xml : Idal
    {
        XElement traineeRoot;
        XElement testerRoot;
        XElement testRoot;
        XElement adminRoot;
        XElement configRoot;

        string traineeXml = @"trainee.Xml";
        string testerXml = @"tester.Xml";
        string testXml = @"test.Xml";
        string adminXml = @"admin.Xml";
        string configXml = @"config.Xml";

        static Dal_to_xml DALinstance = null;
        public static Dal_to_xml GetInstance()
        {
            if (DALinstance == null)
                DALinstance = new Dal_to_xml();
            return DALinstance;
        }

        public Dal_to_xml()
        {
            if (!File.Exists(traineeXml))
                createFile(traineeXml);
            else
                loadFile(traineeXml);
            if (!File.Exists(testerXml))
                createFile(testerXml);
            else
                loadFile(testerXml);
            if (!File.Exists(testXml))
                createFile(testXml);
            else
                loadFile(testXml);
            if (!File.Exists(adminXml))
                createFile(adminXml);
            else
                loadFile(adminXml);
            if (!File.Exists(configXml))
                createFile(configXml);
            else
                loadFile(configXml);
            

        }

        private void loadFile(string str)
        {
            try
            {
                if (str == traineeXml)
                {
                    traineeRoot = XElement.Load(str);
                }
                if (str == testerXml)
                {
                    testerRoot = XElement.Load(str);
                }
                if (str == testXml)
                {
                    testRoot = XElement.Load(str);
                }
                if (str == adminXml)
                {
                    adminRoot = XElement.Load(str);
                }
                if (str == configXml)
                {
                    configRoot = XElement.Load(str);
                }
            }
            catch
            {
                throw new Exception("can't load the file.");
            }
        }

        private void createFile(string str)
        {
            if (str == traineeXml)
            {
                traineeRoot = new XElement("trainees");
                traineeRoot.Save(str);
            }
            if (str == testerXml)
            {
                testerRoot = new XElement("testers");
                testerRoot.Save(str);
            }
            if (str == testXml)
            {
                testRoot = new XElement("tests");
                testRoot.Save(str);
            }
            if (str == adminXml)
            {
                adminRoot = new XElement("admin");
                adminRoot.Save(str);
                XElement xelement = new XElement("admin",
            new XElement("adminID", "205951304"),
            new XElement("adminName", "yacov"));

                adminRoot.Add(xelement);
                adminRoot.Save(adminXml);
            }
            if (str == configXml)
            {
                configRoot = new XElement("configuration");
                configRoot.Save(str);
            }
        }

        public void addTest(Test a)
        {
            a.testId = Configuration.firstNum;
            Configuration.firstNum++;
            XElement xelement = new XElement("test",
            new XElement("testID", a.testId),
            new XElement("testerID", a.testerId),
            new XElement("traineeID", a.traineeId),
            new XElement("testDate", a.testDate),
            new XElement("testDay", a.testDay),
            new XElement("testHour", a.testHour),
            new XElement("address", new XElement("city", a.beginOfTestAdr.city), new XElement("street", a.beginOfTestAdr.street), new XElement("building", a.beginOfTestAdr.building)),
            new XElement("keepDis", a.keepDis),
            new XElement("reversePark", a.reversePark),
            new XElement("mirror", a.mirror),
            new XElement("signaling", a.signaling),
            new XElement("lights", a.lights),
            new XElement("belt", a.belt),
            new XElement("safetyDrive", a.safetyDrive),
            new XElement("priority", a.priority),
            new XElement("score", a.score),
            new XElement("check", a.check),
            new XElement("note", a.signaling));
            
            testRoot.Add(xelement);
            testRoot.Save(testXml);
        }
        public void addTestId(Test a, int id)
        {
            if (id == 0)
            {
                a.testId = Configuration.firstNum;
                Configuration.firstNum++;
            }
            XElement xelement = new XElement("test",
            new XElement("testID", a.testId),
            new XElement("testerID", a.testerId),
            new XElement("traineeID", a.traineeId),
            new XElement("testDate", a.testDate),
            new XElement("testDay", a.testDay),
            new XElement("testHour", a.testHour),
            new XElement("address", new XElement("city", a.beginOfTestAdr.city), new XElement("street", a.beginOfTestAdr.street), new XElement("building", a.beginOfTestAdr.building)),
            new XElement("keepDis", a.keepDis),
            new XElement("reversePark", a.reversePark),
            new XElement("mirror", a.mirror),
            new XElement("signaling", a.signaling),
            new XElement("lights", a.lights),
            new XElement("belt", a.belt),
            new XElement("safetyDrive", a.safetyDrive),
            new XElement("priority", a.priority),
            new XElement("score", a.score),
            new XElement("check", a.check),
            new XElement("note", a.signaling));

            testRoot.Add(xelement);
            testRoot.Save(testXml);
        }
        public void addTester(Tester a)
        {
            try
            {
                string str = convertWHToXml(a.workHour);
                XElement xelement = new XElement("tester",
                new XElement("id", a.id),
                new XElement("lastName", a.lastName),
                new XElement("firstName", a.firstName),
                new XElement("birth", a.birth),
                new XElement("gender", a.gender),
                new XElement("phone", a.phone),
                new XElement("address", new XElement("city", a.addr.city), new XElement("street", a.addr.street), new XElement("building", a.addr.building)),
                new XElement("experience", a.experience),
                new XElement("maxTests", a.maxTests),
                new XElement("carType", a.carType),
                new XElement("gearBox", a.gearBox),
                new XElement("schoolName", a.schoolName),
                new XElement("maxDis", a.maxDist),
                new XElement("workHours", str));

                testerRoot.Add(xelement);
                testerRoot.Save(testerXml);
            }
            catch
            {

            }
        }

        private string convertWHToXml(bool[,] tmp)
        {
            string str = "";
            for (int i= 0; i < 5;i++)
                for(int j=0;j<6;j++)
                {
                    str += tmp[i, j] + " ";
                }
            return str;
        }

        private bool[,] convertWH(string str)
        {
            int k = 0;
            bool[,] tmp = new bool[5, 6];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 6; j++)
                {
                    tmp[i, j] = bool.Parse((str.Split(' ')[k++]));
                }
            return tmp;
        }

        public void addTrainee(Trainee a)
        {
            try
            {
                a.myTestId = Configuration.firstNum;
                XElement xelement = new XElement("trainee",
                new XElement("id", a.id),
                new XElement("lastName", a.lastName),
                new XElement("firstName", a.firstName),
                new XElement("birth", a.birth),
                new XElement("gender", a.gender),
                new XElement("phone", a.phone),
                new XElement("address", new XElement("city", a.addr.city), new XElement("street", a.addr.street), new XElement("building", a.addr.building)),
                new XElement("carType", a.carType),
                new XElement("gearBox", a.gearBox),
                new XElement("schoolName", a.schoolName),
                new XElement("teacher", a.teacher),
                new XElement("classNum", a.classNum),
                new XElement("maxDis", a.maxDis),
                new XElement("myTesterId", a.myTesterId),
                new XElement("myTestId", a.myTestId),
                new XElement("testNum", a.testsNum),
                new XElement("testDate", a.testDate),
                new XElement("testDay", a.testDay),
                new XElement("testHour", a.testHour));

                traineeRoot.Add(xelement);
                traineeRoot.Save(traineeXml);
            }
            catch
            {

            }
        }

        public void deleteTester(Tester a)
        {
            XElement tmp = ((from t in testerRoot.Elements()
                             where t.Element("id").Value == a.id.ToString()
                             select t).FirstOrDefault());
            tmp.Remove();
            testerRoot.Save(testerXml);
        }

        public void deleteTrainee(Trainee a)
        {
            XElement tmp = ((from t in traineeRoot.Elements()
                             where t.Element("id").Value == a.id.ToString()
                             select t).FirstOrDefault());
            tmp.Remove();
            traineeRoot.Save(traineeXml);
        }

        public List<Tester> getTesters()
        {
            testerRoot = XElement.Load(testerXml);
            List<Tester> list;
            list = (from tmp in testerRoot.Elements()
                    select new Tester()
                    {
                        id = int.Parse(tmp.Element("id").Value),
                        lastName = tmp.Element("lastName").Value,
                        firstName = tmp.Element("firstName").Value,
                        birth = DateTime.Parse(tmp.Element("birth").Value),
                        gender = (BE._gender)Enum.Parse(typeof(BE._gender), tmp.Element("gender").Value),
                        phone = tmp.Element("phone").Value,
                        addr = new BE.address()
                        {
                            city = tmp.Element("address").Element("city").Value,
                            street = tmp.Element("address").Element("street").Value,
                            building = int.Parse(tmp.Element("address").Element("building").Value),
                        },
                        experience = int.Parse(tmp.Element("experience").Value),
                        maxTests = int.Parse(tmp.Element("maxTests").Value),
                        carType = (BE.car_Type)Enum.Parse(typeof(BE.car_Type), tmp.Element("carType").Value),
                        gearBox = (BE.gear_Box)Enum.Parse(typeof(BE.gear_Box), tmp.Element("gearBox").Value),
                        schoolName = (BE.school_Name)Enum.Parse(typeof(BE.school_Name), tmp.Element("schoolName").Value),
                        maxDist = int.Parse(tmp.Element("maxDis").Value),
                        workHour = convertWH(tmp.Element("workHours").Value)
                    }).ToList();
            return list;
        }

        public List<Test> getTests()
        {
            testRoot = XElement.Load(testXml);
            List<Test> list;
            list = (from tmp in testRoot.Elements()
                    select new Test()
                    {
                        testId = int.Parse(tmp.Element("testID").Value),
                        testerId = int.Parse(tmp.Element("testerID").Value),
                        traineeId = int.Parse(tmp.Element("traineeID").Value),
                        testDate = DateTime.Parse(tmp.Element("testDate").Value),
                        testDay = (BE.days)Enum.Parse(typeof(BE.days), tmp.Element("testDay").Value),
                        testHour = (BE.hours)Enum.Parse(typeof(BE.hours), tmp.Element("testHour").Value),
                        beginOfTestAdr = new BE.address()
                        {
                            city = tmp.Element("address").Element("city").Value,
                            street = tmp.Element("address").Element("street").Value,
                            building = int.Parse(tmp.Element("address").Element("building").Value),
                        },
                        keepDis = bool.Parse(tmp.Element("keepDis").Value),
                        reversePark = bool.Parse(tmp.Element("reversePark").Value),
                        mirror = bool.Parse(tmp.Element("mirror").Value),
                        signaling = bool.Parse(tmp.Element("signaling").Value),
                        lights = bool.Parse(tmp.Element("lights").Value),
                        belt = bool.Parse(tmp.Element("belt").Value),
                        safetyDrive = bool.Parse(tmp.Element("safetyDrive").Value),
                        priority = bool.Parse(tmp.Element("priority").Value),
                        score = bool.Parse(tmp.Element("score").Value),
                        check = bool.Parse(tmp.Element("check").Value),
                        note = tmp.Element("note").Value
                    }).ToList();
            return list;
        }

        public List<Trainee> getTrainees()
        {
            traineeRoot=XElement.Load(traineeXml);
            List<Trainee> list;
            list = (from tmp in traineeRoot.Elements()
                    select new Trainee()
                    {
                        id = int.Parse(tmp.Element("id").Value),
                        lastName = tmp.Element("lastName").Value,
                        firstName = tmp.Element("firstName").Value,
                        birth = DateTime.Parse(tmp.Element("birth").Value),
                        gender = (BE._gender)Enum.Parse(typeof(BE._gender), tmp.Element("gender").Value),
                        phone = tmp.Element("phone").Value,
                        addr = new BE.address()
                        {
                            city = tmp.Element("address").Element("city").Value,
                            street = tmp.Element("address").Element("street").Value,
                            building = int.Parse(tmp.Element("address").Element("building").Value),
                        },
                        carType = (BE.car_Type)Enum.Parse(typeof(BE.car_Type), tmp.Element("carType").Value),
                        gearBox = (BE.gear_Box)Enum.Parse(typeof(BE.gear_Box), tmp.Element("gearBox").Value),
                        schoolName = (BE.school_Name)Enum.Parse(typeof(BE.school_Name), tmp.Element("schoolName").Value),
                        teacher = tmp.Element("teacher").Value,
                        classNum = int.Parse(tmp.Element("classNum").Value),
                        maxDis = int.Parse(tmp.Element("maxDis").Value),
                        myTesterId = int.Parse(tmp.Element("myTesterId").Value),
                        myTestId = int.Parse(tmp.Element("myTestId").Value),
                        testsNum = int.Parse(tmp.Element("testNum").Value),
                        testDate = DateTime.Parse(tmp.Element("testDate").Value),
                        testDay = (BE.days)Enum.Parse(typeof(BE.days), tmp.Element("testDay").Value),
                        testHour = (BE.hours)Enum.Parse(typeof(BE.hours), tmp.Element("testHour").Value)
                    }).ToList();
            return list;
        }

        public void updateTest(Test a)
        {
            XElement tmp = ((from t in testRoot.Elements()
                             where t.Element("testID").Value == a.testId.ToString()
                             select t).FirstOrDefault());
            tmp.Remove();
            addTestId(a, a.testId);
            testRoot.Save(testXml);
        }

        public void updateTester(Tester a)
        {
            XElement tmp = ((from t in testerRoot.Elements()
                             where t.Element("id").Value == a.id.ToString()
                             select t).FirstOrDefault());
            tmp.Remove();
            addTester(a);
            testerRoot.Save(testerXml);
        }

        public void updateTrainee(Trainee a)
        {
            XElement tmp = ((from t in traineeRoot.Elements()
                             where t.Element("id").Value == a.id.ToString()
                             select t).FirstOrDefault());
            tmp.Remove();
            addTrainee(a);
            traineeRoot.Save(traineeXml);
        }

        
    }
}
