namespace ecommerce.src.Models
{
    public class VehiclePortalUser
    {
        public VehiclePortalUser()
        {
            this.OwnedCars = new List<BuyCar>();
            this.CarsUnderRent = new List<RentCar>();
        }

        public string VehiclePortalUsername { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public decimal Balance { get; set; }

        public bool IsRated { get; set; }

        public ICollection<BuyCar> OwnedCars { get; set; }

        public ICollection<RentCar> CarsUnderRent { get; set; }
    }
}
