using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession03_View_LHL.Controllers
{
    public class LHLStudentController : Controller
    {
        // GET: LHLStudent
        public ActionResult Index()
        {
            // dữ liệu từ ViewData
            ViewData["msg"] = "View Data - Lê Hoàng Long";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss - tt - dd/MM/yyyy");
            return View();
        }

        public  ActionResult StudentList()
        {
            //sử dụng ViewBag
            // Lưu trữ giá trị đơn 
            ViewBag.titlename = "Dánh sách Sinh Viên Của Khóa Lê Hoàng Long";
            // Giá trị một tập hợp
            string[] names = { "Hoàng Minh", "Minh nam", "Khánh Duy" };
            ViewBag.list = names;
            //Giá trị là một đối tượng
            var obj = new
            {
                ID = 100,
                Name = "Hoàng Long",
                Age = 20
            };
            ViewBag.Student = obj;
            return View();
        }

        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}