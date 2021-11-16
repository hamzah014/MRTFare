using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MRTFare.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace MRTFare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            this.configuration = config;
        }



        public IList<Users> GetUserList()
        {
            IList<Users> userlist = new List<Users>();


            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("MrtConnStr"));

            string sqlcmd = @"SELECT * FROM Users";

            SqlCommand cmd = new SqlCommand(sqlcmd, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userlist.Add(
                                new Users()
                                {
                                    Id = reader.GetInt32(0),
                                    Email = reader.GetString(1),
                                    Name = reader.GetString(2),
                                    IcNo = reader.GetString(3),
                                    Password = reader.GetString(4),
                                    Role = reader.GetString(5)
                                }
                              );
                }

            }
            catch(Exception ex)
            {
                RedirectToAction("Error");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return userlist;

        }

        public IActionResult Index()
        {
            
            if (HttpContext.Session.GetInt32("userid") == null) 
            {
                ViewBag.Name = "Everyone";

            }
            else
            {

                int userid = (int)HttpContext.Session.GetInt32("userid");
                String role = HttpContext.Session.GetString("role");

                IList<Users> dbList = GetUserList();

                var result = dbList.Where(x => x.Id == userid);

                ViewBag.UserId = userid;
                ViewBag.Role = role;
                ViewBag.Name = result.FirstOrDefault().Name;

            }

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
