using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ID = "21-45236-2" ;
            ViewBag.Gmail = "https://mail.google.com/mail";
            ViewBag.Github = "https://github.com/meherab111";
            return View();
        }

        public ActionResult Project()
        {
            var proj1 = new Project();

            proj1.course_name = "OOP1 (Java)";
            proj1.project_title = "School Management System";
            proj1.description = "Made a School Management System using language JAVA, where we implemented the OOP concept.";

            var proj2 = new Project();

            proj2.course_name = "OOP2 (C#)";
            proj2.project_title = "Electronic Devices Shop Management System";
            proj2.description = "Made a Electronic Devices Shop Management System using, where we implemented the OOP concept.";

            var proj3 = new Project();

            proj3.course_name = "Web-Technology";
            proj3.project_title = "Clothing Shop Management System";
            proj3.description = "Made a Clothing Shop Management System, where i personally took Admin department and worked on it using raw HTML, CSS, JS, PHP, MySQL";


            Project[] project_arr = new Project[] { proj1, proj2, proj3 };

            ViewBag.Array = project_arr;


            return View();
        }

        public ActionResult Personal_Info()
        {

            var per_info = new Personal_Info();
            
            per_info.name = "Meherab Hassan.";
            per_info.father_name = "Amzad.";
            per_info.mother_name = "Aleya.";
            per_info.work = "Student.";
            per_info.email = "mehrabborno@gmail.com";
            per_info.address = "Uttara, Dhaka-1230.";

            Personal_Info[] per_info_arr = new Personal_Info[] { per_info };

            ViewBag.Array = per_info_arr;

            return View();
        }
        public ActionResult Education()
        {
            var edu1 = new Education();

            edu1.degree = "BSc. Honours in CSE";
            edu1.year = "2025";
            edu1.institute = "American International University-Bangladesh";

            var edu2 = new Education();

            edu2.degree = "Higher Secondary Certificate";
            edu2.year = "2020";
            edu2.institute = "Uttara High School And College";

            var edu3 = new Education();

            edu3.degree = "Secondary School Certificate";
            edu3.year = "2018";
            edu3.institute = "Uttara High School And College";

            Education[] edu_arr = new Education[] { edu1, edu2, edu3 };

            ViewBag.Array = edu_arr;


            return View();
        }

        public ActionResult Reference()
        {

            var refer1 = new Reference();

            refer1.reference_name = "[1] Dr. Md. Abdullah-Al-Jubayer.";

            var refer2 = new Reference();

            refer2.reference_name = "[2] Dr. Harun Ur Rashid.";

            var refer3 = new Reference();

            refer3.reference_name = "[3] Mr. Rahim Mollah.";

            Reference[] refer_arr = new Reference[] { refer1, refer2, refer3 };

            ViewBag.Array = refer_arr;



            return View();
        }
    }
}