﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GitGud.Models;
using Microsoft.Extensions.Configuration;

namespace GitGud.Controllers.Web
{
    public class AppController : Controller
    {
        private GitGudContext _context;
        private IConfigurationRoot _config;

        public AppController(IConfigurationRoot config, GitGudContext context)
        {
            _config = config;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse()
        {
            var data = _context.Songs.ToList();

            return View(data);
        }

        public IActionResult Charts()
        {
            return View();
        }

        public IActionResult HotTracks()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
