using GlobalLogicTeatTask.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalLogicTeatTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Move(string startPath, string extractPath)
        {
            try
            {
               FolderOperation.MoveFolder(startPath, extractPath);
                ViewBag.Message = "Completed!!!";
                return View();
            }
            catch (IOException exp)
            {
                ViewBag.Message = exp.Message;
                return View();
            }
            catch 
            {
                ViewBag.Message = "Exception occured!!!";
                return View();
            }
        }

    }
}