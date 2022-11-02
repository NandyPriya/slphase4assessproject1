using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerSupportLogger.Models
{
    public class Class2
    {
        
        public int LogID { get; set; }
        [DataType (DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string LogStatus { get; set; }

        public string Description { get; set; }
    }
}