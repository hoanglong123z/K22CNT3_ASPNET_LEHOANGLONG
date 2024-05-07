using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession02_controlled_LHL.Controllers
{
    public class ProJectController : Controller
    {
        // GET: ProJect ~ http://localhost:..../ProJect
        public ActionResult Index()
        {
            ViewBag.Name = "Hoàng Long - 2210900037";
            return View();
        }

        public ActionResult Details(int? ID)
        {
            ViewBag.ID = ID;
            return View();
        }

        public string GetName()
        {
            return "Lê Hoàng Long - 2210900037";
        }

        public JsonResult ListName()
        {
            string[] names = { "Việt", "Minh", "Duy", "Bình" };

            return Json(names,JsonRequestBehavior.AllowGet);
        }
    }
}