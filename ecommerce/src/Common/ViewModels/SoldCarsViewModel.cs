using ecommerce.src.Models;

namespace ecommerce.src.Common.ViewModels
{
    public class SoldCarsViewModel
    {
        public string UserId { get; set; }

        public string User { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public decimal Price { get; set; }

        public DateTime BoughtOn { get; set; }
    }
}
