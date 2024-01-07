using Assignment_1_Exercise_Hands_On_Coding.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Diagnostics;

namespace Assignment_1_Exercise_Hands_On_Coding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<HotelBooking> bookings = new List<HotelBooking>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult HotelBookingDetails()
        {
            return View(bookings);
        }

        public IActionResult Index()
        {
            HotelBooking hotelBooking = new HotelBooking()
            {
                id = 1,
                guestName = "James",
                dateStart = DateTime.Now,
                dateEnd = DateTime.Now
            };
            return View(hotelBooking);
            
        }

        public IActionResult Create()
        {
            var HotelBookingVm = new HotelBooking();
            return View(HotelBookingVm);
        }

        public IActionResult CreateBooking(HotelBooking hotelBookingViewModel)
        {
            bookings.Add(hotelBookingViewModel);
            return RedirectToAction(nameof(Index));
        }

      
    }
}