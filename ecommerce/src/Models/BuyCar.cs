namespace ecommerce.src.Models
{
    public class BuyCar
    {
        public int BuyCarId { get; set; }

        public string UserId { get; set; }

        public VehiclePortalUser User { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public decimal Price { get; set; }

        public DateTime BoughtOn { get; set; }
    }
}
