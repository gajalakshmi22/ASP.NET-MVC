using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFileDemo.Common;

namespace MVCFileDemo.Controllers
{
    public class HomeController : Controller
    {
        [TrackExecutionTime]
        public string Index()
        {
            return "Index action invoked";
        }

        [TrackExecutionTime]
        public string Welcome()
        {
            throw new Exception("Exception Occured");
        }
    }
}