using CustomDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerSupportLogger.Controllers
{
    public class LogController : Controller
    {

        //public ActionResult Index()
        //{
        //    return View();
        //}
        Class1 nh = null;
        public LogController()
        {
           nh=new Class1();
        }
        [HttpGet]
        public ActionResult Complaint()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complaint(FormCollection c)
        {
            CustLogInfo c1 = new CustLogInfo();
            c1.LogId = Convert.ToInt32(c["LogID"]);
            c1.CustEmail = c["CustomerEmail"].ToString();
            c1.CustName = c["CustomerName"].ToString();
            c1.LogStatus = c["LogStatus"].ToString();
            c1.Description = c["Description"].ToString();
            c1.UserId = Convert.ToInt32(TempData["user"]);
            TempData["user"] = c1.UserId;
            bool d =nh.Save(c1);
           if(d)
            {
                ViewBag.Message2 = "Saved Succesfully";
                return View();
            }
           else
            {
                ViewBag.Message3 = "Not Saved";
                return View();
            }
            
            
        }
    }
}