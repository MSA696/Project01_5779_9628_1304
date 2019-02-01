using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class factoryDAL
    {
        protected factoryDAL() { }

        public static Idal DALGetInstance()
        {
            return Dal_to_xml.GetInstance();
        }

        /*protected static Dal_imp instance = null;

        public static Dal_imp GetInstance()
        {
            if (instance == null)
                instance = new Dal_imp();
            return instance;
        }*/

        /*private static Idal dal = null;
        public static Idal getInstance()
        {
            //return bl ?? (bl = new BL_imp());
            if (dal == null)
                dal = new factoryDAL();
            return dal;
        }*/
    }
}
