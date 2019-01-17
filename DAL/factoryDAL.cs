using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class factoryDAL
    {
        protected factoryDAL() { }

        protected static factoryDAL instance = null;

        public static factoryDAL GetIntance()
        {
            if (instance == null)
                instance = new factoryDAL();
            return instance;
        }
        private static Idal dal = null;
        public static Idal getInstance()
        {
            //return bl ?? (bl = new BL_imp());
            if (dal == null)
                dal = new factoryDAL();
            return dal;
        }
    }
}
