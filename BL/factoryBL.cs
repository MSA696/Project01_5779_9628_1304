using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class factoryBL
    {
        protected factoryBL() { }

        public static IBL BLGetInstance()
        {
            return BL_imp.GetInstance();
        }
    }
}
