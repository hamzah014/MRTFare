using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using MRTFare.Models;

namespace MRTFare.Controllers
{
    public class BookingController : Controller
    {
        private readonly IConfiguration configuration;

        public BookingController(IConfiguration config)
        {
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
            catch
            {
                RedirectToAction("Error");
            }
            finally
            {
                conn.Close();
            }

            return userlist;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookingTicket()
        {

            if (HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Logout", "User");

            }
            else
            {

                int userid = (int)HttpContext.Session.GetInt32("userid");

                IList<Users> dbList = GetUserList();

                var result = dbList.Where(x => x.Id == userid);

                ViewBag.UserId = userid;

                MRT mrt = new MRT();

                mrt.IndexOrigin = mrt.IndexDestination = mrt.IndexCategory = mrt.IndexTrip = -1;

                return View(mrt);
            }

        }


        [HttpPost]
        public IActionResult BookingTicket(MRT mrt)
        {


            if (HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Logout", "User");

            }
            else
            {

                int userid = (int)HttpContext.Session.GetInt32("userid");

                IList<Users> dbList = GetUserList();

                var result = dbList.Where(x => x.Id == userid);

                ViewBag.UserId = userid;


                return View("BookingInvoice", mrt);
            }
        }

    }
}
