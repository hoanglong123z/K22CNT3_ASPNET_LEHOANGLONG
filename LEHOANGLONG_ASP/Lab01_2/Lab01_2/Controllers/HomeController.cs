using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Rất Là Xin Chào";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Mua Đồ Ăn đê";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Thực đơn hôm nay";
            string[] products = { "gà quay", "cá chép om dưa", "vịt quay" };
            ViewBag.Products = products;
            return View();
        }
    }
}