namespace ecommerce.src.Common.ViewModels
{
    public class RateCarBindingModel
    {
        public int CarId { get; set; }

        public int Rating { get; set; }

        public string UserId { get; set; }

        public VehiclePortalUser User { get; set; }
    }
}
