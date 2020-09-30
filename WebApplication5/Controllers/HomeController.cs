using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Identifiants());
        }
        [HttpPost]
        public ActionResult index (Models.Identifiants Idts)
        {
            
            if (Idts.UserName =="toto" && Idts.Passwd=="azerty" )
            {
            }
            else
            {
                Idts.Message = "Erreur d'identification";
                Idts.Passwd = string.Empty;

            }
            
            return View(Idts);
        }
    }
}