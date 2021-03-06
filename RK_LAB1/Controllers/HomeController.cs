﻿using System;
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
        public ViewResult LogIn()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RegisterationForm()
        {
            return View();
        }


        [HttpPost]
       public ViewResult LogIn(User student)
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

        public ViewResult Summary()
        {

            return View(StudentRepository.Responses);
        }

    }
}
