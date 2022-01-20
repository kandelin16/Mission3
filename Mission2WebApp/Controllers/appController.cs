using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission3WebApp.Models;

namespace Mission3WebApp.Controllers
{
    public class appController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title = "All about Kyle";
            return View();
        }
        [HttpGet]
        public ActionResult GradeCalculator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GradeCalculator(GradeCalculator model)
        {
            var total = (model.Assignments + model.Exams + model.GroupProjects + model.Intex + model.Quizzes) / 5;
            if ((model.Assignments > 100 || model.Assignments < 0) || (model.Exams > 100 || model.Exams <0) || (model.GroupProjects > 100 || model.GroupProjects < 0) || (model.Intex > 100 || model.Intex < 0) || (model.Quizzes > 100 || model.Quizzes < 0))
            {
                ViewBag.letterGrade = "Please input percentages between 0 and 100";
                ViewBag.button = false;
            }
            else
            {
                ViewBag.numberGrade = total;
                ViewBag.button = true;
                if (total >= 93)
                {
                    ViewBag.letterGrade = "A";
                }
                else if (total >= 90)
                {
                    ViewBag.letterGrade = "A-";
                }
                else if (total >= 87)
                {
                    ViewBag.letterGrade = "B+";
                }
                else if (total >= 83)
                {
                    ViewBag.letterGrade = "B";
                }
                else if (total >= 80)
                {
                    ViewBag.letterGrade = "B-";
                }
                else if (total >= 77)
                {
                    ViewBag.letterGrade = "C+";
                }
                else if (total >= 73)
                {
                    ViewBag.letterGrade = "C";
                }
                else if (total >= 70)
                {
                    ViewBag.letterGrade = "C-";
                }
                else if (total >= 67)
                {
                    ViewBag.letterGrade = "D+";
                }
                else if (total >= 63)
                {
                    ViewBag.letterGrade = "D";
                }
                else if (total >= 60)
                {
                    ViewBag.letterGrade = "D-";
                }
                else if (total >= 0)
                {
                    ViewBag.letterGrade = "F";
                }
            }
            
            return View();
        }
    }
}
