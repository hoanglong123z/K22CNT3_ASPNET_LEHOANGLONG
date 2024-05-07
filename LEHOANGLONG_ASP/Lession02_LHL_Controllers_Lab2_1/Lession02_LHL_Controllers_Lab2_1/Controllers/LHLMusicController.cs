using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession02_LHL_Controllers_Lab2_1.Controllers
{
    public class LHLMusicController : Controller
    {
        // GET: LHLMusic
        public ActionResult ShowMusic()
        {
            return View();
        }
        public ActionResult DownloadMusic()
        {
            return View();
        }
    }
}