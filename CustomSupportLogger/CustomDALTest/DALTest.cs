using CustomDAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDALTest
{
    [TestFixture]
    public class UserInfoTest
    {
        [TestCase(1,"scott123", ExpectedResult = true)]
       
        public bool ValidateUserTest(int k ,string j)
        {
            UserInfo u = new UserInfo();
            u.UserId = k;
            u.Password = j;
            bool ans = u.Enrollstudent1();
            return ans;
        }


    }
    public class CustLogInfoTest
    {
        [TestCase]

        public void GetAllLogInfoesTest()
        {
            CustLogInfo c = new CustLogInfo();

            c.LogId = 1;
            c.LogStatus = "success";
            Assert.AreEqual(c.LogId,1);
            
        }
        [TestCase]

        public void SaveLogInfoesTest()
        {
            CustLogInfo c = new CustLogInfo();

            c.UserId = 2;
            Assert.AreEqual(c.UserId,2);

        }


    }


}
