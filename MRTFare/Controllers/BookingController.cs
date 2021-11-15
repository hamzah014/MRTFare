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
        public IList<MRT> GetBookingList()
        {
            IList<MRT> booklist = new List<MRT>();


            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("MrtConnStr"));

            string sqlcmd = @"SELECT * FROM booking";

            SqlCommand cmd = new SqlCommand(sqlcmd, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    booklist.Add(
                                new MRT()
                                {
                                    Id = reader.GetInt32(0),
                                    UserId = reader.GetInt32(1),
                                    ViewId = reader.GetString(2),
                                    ViewDateTime = reader.GetDateTime(3),
                                    IndexOrigin = reader.GetInt32(4),
                                    IndexDestination = reader.GetInt32(5),
                                    IndexCategory = reader.GetInt32(6),
                                    IndexTrip = reader.GetInt32(7),
                                    Quantity = reader.GetInt32(8),
                                    ViewTotalPrice = reader.GetDouble(9)
                                }
                              );
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("error read list book " + ex.Message );
                RedirectToAction("Error");
            }
            finally
            {
                conn.Close();
            }

            return booklist;

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


                if (ModelState.IsValid)
                {

                    SqlConnection conn = new SqlConnection(configuration.GetConnectionString("MrtConnStr"));
                    SqlCommand cmd = new SqlCommand("spInsertBooking", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@bookingid", mrt.BookingId);
                    cmd.Parameters.AddWithValue("@bookingdate", mrt.BookDateTime);
                    cmd.Parameters.AddWithValue("@indexorigin", mrt.IndexOrigin);
                    cmd.Parameters.AddWithValue("@indexdestination", mrt.IndexDestination);
                    cmd.Parameters.AddWithValue("@indexcategory", mrt.IndexCategory);
                    cmd.Parameters.AddWithValue("@indextrip", mrt.IndexTrip);
                    cmd.Parameters.AddWithValue("@quantity", mrt.Quantity);
                    cmd.Parameters.AddWithValue("@totalprice", mrt.totalPrice);


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                    catch
                    {
                        return View();
                    }
                    finally
                    {
                        conn.Close();
                    }

                    return View("BookingInvoice", mrt);
                }
                else
                {
                    Console.WriteLine(mrt.BookingId);
                    return View(mrt);
                }

            }
        }


        public IActionResult UserBooking()
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


                IList<MRT> booklist = GetBookingList();
                var userbook = booklist.Where(x => x.UserId == userid).OrderByDescending(x => x.ViewDateTime);

                return View(userbook);
            }
        
        }

        public IActionResult Details(int id)
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


                IList<MRT> booklist = GetBookingList();
                var userbook = booklist.First(x => x.Id == id);

                return View(userbook);
            }

        }


    }
}
