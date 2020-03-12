using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RK_LAB1.Models;

namespace RK_LAB1.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View("Welcome");
        }

        [HttpGet]
        public ViewResult StudentForm()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RegisterationForm()
        {
            return View();
        }


        [HttpPost]
       public ViewResult StudentForm(Student student)
  {
            if (ModelState.IsValid)
            {
                StudentRepository.AddResponse(student);
                return View("StudentResponse", student);
            }
            else
            {// The validation error
                return View();
            }
        }


     /*   [HttpPost]
        public ViewResult CourseForm(Course course)
        {
            if (ModelState.IsValid)
            {
                CourseRepository.AddResponse(course);
                return View("CourseResponse", course);
            }
            else
            {// The validation error
                return View();
            }
        }
        */
        public ViewResult Summary()
        {

            return View(StudentRepository.Responses);
        }

        public ViewResult CourseSummary()
        {

            return View(CourseRepository.Responses);
        }
    }
}
