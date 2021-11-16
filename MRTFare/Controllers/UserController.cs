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
        public IActionResult LoginUser()
        {
            Users users = new Users();
            return View(users);
        }

        [HttpPost]
        public IActionResult LoginUser(Users users)
        {
            String email = users.Email;
            String password = users.Password;

            IList<Users> dbList = GetUserList();

            var result = dbList.Where(x => x.Email == email && x.Password == password);
            
            if (result.Count() == 0)
            {
                Console.WriteLine("apa ni 0");
                return View("LoginUser");
            }
            else
            {
                int userid = result.FirstOrDefault().Id;
                String role = result.FirstOrDefault().Role;
                Console.WriteLine("id " + userid);
                Console.WriteLine("role " + role);

                //set session for user
                HttpContext.Session.SetInt32("userid", userid);
                HttpContext.Session.SetString("role", role);

                return RedirectToAction("Index", "Home");
            
            }
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
            if (ModelState.IsValid)
            {

                SqlConnection conn = new SqlConnection(configuration.GetConnectionString("MrtConnStr"));
                SqlCommand cmd = new SqlCommand("spInsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                String userrole = "customer";

                cmd.Parameters.AddWithValue("@email", users.Email);
                cmd.Parameters.AddWithValue("@name", users.Name);
                cmd.Parameters.AddWithValue("@icno", users.IcNo);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@role", userrole);


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

                return RedirectToAction("LoginUser", "User");
            }
            else
            {
                Console.WriteLine(users.Name);
                return View(users);
            }
        }


        public IActionResult Logout() 
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LoginUser");
        }


        public IActionResult UserList()
        {


            if (HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Logout", "User");

            }
            else
            {

                int userid = (int)HttpContext.Session.GetInt32("userid");
                String role = HttpContext.Session.GetString("role");

                ViewBag.UserId = userid;
                ViewBag.Role = role;

                IList<Users> dbList = GetUserList();

                var result = dbList.Where(x => x.Role == "customer");

                return View(result);
            }
        }

    }
}
