using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession02_LHL_Controllers_Lab2_2.Controllers
{
    public class LHLProductController : Controller
    {
        // GET: LHLProduct
        public ActionResult Showproduct()
        {
            return View();
        }
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        public ActionResult DetailsProduct(string productName, int? productId)
        {
            ViewBag.productName = productName;
            ViewBag.id = productId;
            return View();
        }
    }
}