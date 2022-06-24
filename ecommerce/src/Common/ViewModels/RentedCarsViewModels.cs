using ecommerce.src.Models;

namespace ecommerce.src.Common.ViewModels
{
    public class RentedCarsViewModels
    {
        public string UserId { get; set; }

        public string User { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal DayPrice { get; set; }
        public decimal DayQuantity { get; set; }

        public decimal TotalPrice() { 
            return DayPrice * DayQuantity;
        }
    }
}
