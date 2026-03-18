using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class VehicleController : Controller

    {
        private static readonly List<Vehicle> _vehicles = new()
{
    // --- Nhóm xe 5 chỗ (Sedan/Hatchback) ---
    new Vehicle { Id=1, Name="HYUNDAI ACCENT 2019", Brand="Hyundai", Year=2019, Transmission="Số tự động", Seats=5, Fuel="Xăng", PricePerDay=900000, Address="Tây Hồ, Hà Nội", ImageUrl="/images/accent.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=2, Name="TOYOTA VIOS 2022", Brand="Toyota", Year=2022, Transmission="Số tự động", Seats=5, Fuel="Xăng", PricePerDay=800000, Address="Hoàn Kiếm, Hà Nội", ImageUrl="/images/vios.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=3, Name="KIA CERATO 2021", Brand="Kia", Year=2021, Transmission="Số tự động", Seats=5, Fuel="Xăng", PricePerDay=1100000, Address="Hai Bà Trưng, Hà Nội", ImageUrl="/images/cerato.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=4, Name="MAZDA 3 2022", Brand="Mazda", Year=2022, Transmission="Số tự động", Seats=5, Fuel="Xăng", PricePerDay=1300000, Address="Cầu Giấy, Hà Nội", ImageUrl="/images/mazda3.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=5, Name="HONDA CITY 2023", Brand="Honda", Year=2023, Transmission="Số tự động", Seats=5, Fuel="Xăng", PricePerDay=950000, Address="Long Biên, Hà Nội", ImageUrl="/images/honda-city.jpg", FreeDeposit=true, HomeDelivery=true },

    // --- Nhóm xe 7 chỗ (MPV/SUV) ---
    new Vehicle { Id=6, Name="SUZUKI XL7 2020", Brand="Suzuki", Year=2020, Transmission="Số tự động", Seats=7, Fuel="Xăng", PricePerDay=1200000, Address="Đống Đa, Hà Nội", ImageUrl="/images/xl7.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=7, Name="MITSUBISHI XPANDER 2022", Brand="Mitsubishi", Year=2022, Transmission="Số tự động", Seats=7, Fuel="Xăng", PricePerDay=1000000, Address="Hà Đông, Hà Nội", ImageUrl="/images/xpander.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=8, Name="TOYOTA FORTUNER 2021", Brand="Toyota", Year=2021, Transmission="Số sàn", Seats=7, Fuel="Dầu", PricePerDay=1500000, Address="Thanh Xuân, Hà Nội", ImageUrl="/images/fortuner.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=9, Name="FORD EVEREST 2023", Brand="Ford", Year=2023, Transmission="Số tự động", Seats=7, Fuel="Dầu", PricePerDay=1800000, Address="Nam Từ Liêm, Hà Nội", ImageUrl="/images/everest.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=10, Name="KIA CARNIVAL 2022", Brand="Kia", Year=2022, Transmission="Số tự động", Seats=7, Fuel="Dầu", PricePerDay=2500000, Address="Cầu Giấy, Hà Nội", ImageUrl="/images/carnival.jpg", FreeDeposit=true, HomeDelivery=true },

    // --- Nhóm xe điện & xe sang ---
    new Vehicle { Id=11, Name="VINFAST VF8 2023", Brand="VinFast", Year=2023, Transmission="Số tự động", Seats=5, Fuel="Điện", PricePerDay=1600000, Address="Tây Hồ, Hà Nội", ImageUrl="/images/vf8.jpg", FreeDeposit=true, HomeDelivery=true },
    new Vehicle { Id=12, Name="MERCEDES C200 2021", Brand="Mercedes", Year=2021, Transmission="Số tự động", Seats=5, Fuel="Xăng", PricePerDay=3500000, Address="Ba Đình, Hà Nội", ImageUrl="/images/mercedes.jpg", FreeDeposit=true, HomeDelivery=true }
};

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Vehicles = _vehicles, // list xe như trước
                NewsItems = new List<NewsItem>
        {
            new() { Title = "HAPPY NEW YEAR - XUÂN BÍNH NGỌ 2026!", ImageUrl = "https://example.com/newyear2025.jpg", Date = "2026" },
            new() { Title = "CHÚC MỪNG NGHỈ LỄ QUỐC KHÁNH 2/9", ImageUrl = "https://example.com/quockhanh.jpg", Date = "2026" },
            // Thêm 3-4 cái nữa từ ảnh bạn
        },        Reviews = new List<Review>
        {
            new() { Name = "Phạm Hoàng", Role = "Giám đốc công ty", Content = "Tôi ung thuê xe tháng tại đây vì anh em tư vấn nhiệt tình...", AvatarUrl = "https://example.com/avatar1.jpg" },
            // Thêm 2 cái nữa
        },
                Partners = new List<string> { "KIA", "Mazda", "Toyota", "Nissan", "Honda", "Hyundai" } // logo text hoặc img
            };

            return View(model);
        }
        public IActionResult SelfDrive()
        {
            return View(_vehicles);
        }
        public IActionResult WithDriver()
        {
            return View(_vehicles);
        }
    }
}