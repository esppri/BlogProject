﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class HomeController : Controller
    {
        BlogDbContext dbContext;
        public HomeController(BlogDbContext _dbContenxt)
        {
            dbContext = _dbContenxt;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostSubscribe(string semail1)
        {
            Subscribe sb = new Subscribe();
            sb.EmailAdress = semail1;
            sb.CreDate = DateTime.Now;

            dbContext.Subscribe.Add(sb);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}