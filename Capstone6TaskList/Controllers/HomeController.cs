using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone6TaskList.Models;

namespace Capstone6TaskList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register(User info)
        {
            TaskListEntities ORM = new TaskListEntities();
            if (ModelState.IsValid)
            {
               /* ORM.Users.Add(info);

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                }
                catch (DbUpdateConcurrencyException ex)
                {
                }*/

            }
            return View();
        }
       
    }
}