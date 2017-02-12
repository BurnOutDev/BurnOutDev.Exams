using BurnOutDev.Exams.Web.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurnOutDev.Exams.Web.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Question(int id)
        {
            return View();
        }
    }
}