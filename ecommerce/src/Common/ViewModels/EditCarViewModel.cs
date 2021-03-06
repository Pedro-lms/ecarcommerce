using ecommerce.src.Models.Enums;

namespace ecommerce.src.Common.ViewModels
{
    public class EditCarViewModel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string CarModel { get; set; }

        public int Year { get; set; }

        public string Features { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public Fuel Fuel { get; set; }

        public Transmission Transmission { get; set; }

        public string SmallImageUrl { get; set; }

        public string LargeImageUrl { get; set; }

        public decimal Price { get; set; }

        public int Rating { get; set; }
    }
}
