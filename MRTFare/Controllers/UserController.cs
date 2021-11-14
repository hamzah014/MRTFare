using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MRTFare.Models;

namespace MRTFare.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration configuration;

        public UserController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LoginUser()
        {
            //HttpContext.Session.SetInt32("userid", 1);
            Users users = new Users();
            return View(users);
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            Users users = new Users();
            return View(users);
        }

        [HttpPost]
        public IActionResult RegisterUser(Users users)
        {
            Console.WriteLine(users.Name);
            return View("LoginUser",users);
        }
    }
}
