using EAD_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAD_CMS.Controllers
{
    public class TeacherController : Controller
    {
        //
        // GET: /Teacher/
        public ActionResult Teacher()
        {
            Teacher teacher = new Teacher();
            
            string username = (string)Session["username"];

            using (CMSEntities db = new CMSEntities())
            {
                var userDetails = db.Teachers.Where(x => x.username == username).FirstOrDefault();

                teacher.name = userDetails.name.ToUpper();
                teacher.username = userDetails.username;

            }

            return View(teacher);
        }
        public ActionResult About()
        {
            return View();
        }
	}
}