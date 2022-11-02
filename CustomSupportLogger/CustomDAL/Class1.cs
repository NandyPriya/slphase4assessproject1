using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDAL
{
    public class Class1
    {
        CSLAzureDbEntities context = null;
        public Class1()
        {
            context = new CSLAzureDbEntities();
        }
        public bool Save(CustLogInfo t)
        {
            try
            {
                context.CustLogInfoes.Add(t);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
