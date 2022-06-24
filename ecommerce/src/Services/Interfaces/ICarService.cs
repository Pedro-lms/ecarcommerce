using ecommerce.src.Models;
using ecommerce.src.Models.Enums;
using ecommerce.src.ServiceModels;

namespace ecommerce.src.Services.Interfaces
{
    public interface ICarService
    {
        Task Add(Car car);
        Task Edit(EditCarServiceModel model);

        Task Delete(int id);

        Task<Car> Details(int id);

        Task<Car> GetById(int id);

        Task<IEnumerable<Car>> GetAll();

        Task<IEnumerable<Car>> GetAllByRating();

        Task<bool> Rate(RateCarServiceModel model, string username);

        Task<bool> Buy(BuyCar buyCar, string username);

        Task<bool> Rent(RentCar rentCar, string username);

        Task<CompareCarServiceModel> CompareCars(int firstCarId, int secondCarId);
    }
}
