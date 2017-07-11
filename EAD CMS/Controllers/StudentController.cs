using EAD_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EAD_CMS.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Student()
        {
            student stu = new student();

            string username = (string)Session["username"];

            using (CMSEntities db=new CMSEntities())
            {
                var userDetails = db.students.Where(x => x.rollno == username).FirstOrDefault();

                if (userDetails != null)
                {
                    stu.name = userDetails.name.ToUpper();
                    stu.rollno = userDetails.rollno;
                    stu.degree = userDetails.degree;
                    stu.batch = userDetails.batch;
                }
                
            }

            return View(stu);
        }
        public ActionResult About()
        {
            return View();
        }
	}
}