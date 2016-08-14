using System;
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
        public ActionResult Index()
        {
            return Redirect("/index.html");
        }

        public JsonResult GetUser(Guid id)
        {
            var user = Logic.UserService.GetUser(id);
            return Json(new
            {
                user = user
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNews()
        {
            return Json(new
            {
                news = Logic.NewsService.GetNews()
            }, JsonRequestBehavior.AllowGet);
        }
    }
}