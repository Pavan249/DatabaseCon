using DatabaseCon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseCon.Controllers
{
    public class PavanController : Controller
    {
        // GET: Pavan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Filling()
        {
            return View();
        }
        public ActionResult Demo(StudentDetails d)
        {
            using(var entity = new tablesEntities3())
            {
                student t = new student();
               
                t.Name = d.Name;
                t.Email = d.Email;
                t.Marks = d.Marks;
                entity.students.Add(t);
                entity.SaveChanges();

            }
            return View();
        }
    }
}