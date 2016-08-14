using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using NewsPortal.BL.Interfaces;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        private IBLUnitOfWork Logic { get; }

        public HomeController(IBLUnitOfWork uowBL)
        {
            Logic = uowBL;
        }
        public JsonResult Index()
        {
            var result = Logic.NewsService.GetNews();
            return Json(new
            {
                roles = result
            }, JsonRequestBehavior.AllowGet);
        }
    }
}