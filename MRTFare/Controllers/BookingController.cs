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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookingTicket()
        {
            ViewBag.Userid = HttpContext.Session.GetInt32("userid");

            MRT mrt = new MRT();

            mrt.IndexOrigin = mrt.IndexDestination = mrt.IndexCategory = mrt.IndexTrip = -1;

            return View(mrt);
        }


        [HttpPost]
        public IActionResult BookingTicket(MRT mrt)
        {


            return View("BookingInvoice",mrt);
        }

    }
}
