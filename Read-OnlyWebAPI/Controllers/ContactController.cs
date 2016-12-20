using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Read_OnlyWebAPI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
    }
}