using ecommerce.src.Models;
using ecommerce.src.ServiceModels;

namespace ecommerce.src.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<RentCar>> GetAllRentedCars();

        Task<IEnumerable<BuyCar>> GetAllSoldCars();

        Task<IEnumerable<BuyCar>> GetAllBoughtCarsByUser(string username);

        Task<IEnumerable<RentCar>> GetAllRentedCarsByUser(string username);

        Task AddFunds(AddFoundServiceModel model, string username);
    }
}
