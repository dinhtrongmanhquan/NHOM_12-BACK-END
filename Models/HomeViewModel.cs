using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class HomeViewModel
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<NewsItem> NewsItems { get; set; } = new List<NewsItem>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<string> Partners { get; set; } = new List<string>();
    }

    public class NewsItem
    {
        public string Title { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Date { get; set; } = "";
    }

    public class Review
    {
        public string Name { get; set; } = "";
        public string Role { get; set; } = "";
        public string Content { get; set; } = "";
        public string AvatarUrl { get; set; } = "";
    }
}