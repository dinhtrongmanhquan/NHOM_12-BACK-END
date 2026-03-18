using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Vehicles = new List<Vehicle>
                {
                    new Vehicle
                    {
                        Id = 1,
                        Name = "Hyundai Accent 2019",
                        Brand = "Hyundai",
                        Year = 2019,
                        Transmission = "Số tự động",
                        Seats = 5,
                        Fuel = "Xăng",
                        PricePerDay = 900000,
                        Address = "Hà Nội",
                        ImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b70?w=800"
                    }
                }
            };

            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}