namespace ecommerce.src.Models
{
    public interface IuserService
    {

        Task<IEnumerable<RentCar>> GetAllRentedCars();

        Task<IEnumerable<BuyCar>> GetAllSoldCars();

        Task<IEnumerable<BuyCar>> GetAllBoughtCarsByUser(string username);

        Task<IEnumerable<RentCar>> GetAllRentedCarsByUser(string username);

        Task AddFunds(AddFundsServiceModel model, string username);

    }
}
