namespace WebApplication1.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;          // Tên xe: Hyundai Accent 2019
        public string Brand { get; set; } = string.Empty;         // Hyundai, Suzuki, Kia,...
        public int Year { get; set; }                             // 2019
        public string Transmission { get; set; } = string.Empty; // Số tự động / Số sàn
        public int Seats { get; set; }                            // 5 chỗ, 7 chỗ,...
        public string Fuel { get; set; } = string.Empty;          // Xăng / Dầu
        public decimal PricePerDay { get; set; }                  // 1.200.000đ
        public string Address { get; set; } = string.Empty;       // Tây Hồ, Hà Nội
        public string ImageUrl { get; set; } = string.Empty;      // link ảnh xe
        public bool FreeDeposit { get; set; } = true;             // Miễn thế chấp
        public bool HomeDelivery { get; set; } = true;
    }
}
