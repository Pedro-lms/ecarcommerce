using ecommerce.src.Data;
using ecommerce.src.Models;
using ecommerce.src.ServiceModels;
using ecommerce.src.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ecommerce.src.Services.Implementations
{
    public class UserService : DataService, IUserService
    {
        public UserService(VehiclePortalDbContext context) : base(context)
        {
        }

        public async Task AddFunds(AddFoundServiceModel model, string username)
        {
            var user = await this.context.Users.SingleOrDefault(u => u.Users.Username == username);

            user.Balance += model.Balance;

            this.context.Update(user);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BuyCar>> GetAllBoughtCarsByUser(string username)
        {
           var boughtCarsByUser = await this.context.RentedCars
                .Include(c => c.Car)
                .Where(u => u.User.UserName == username)
                .ToListAsync();
            return boughtCarsByUser;
        }

        public async Task<IEnumerable<RentCar>> GetAllRentedCars()
        {
            var rentedCars = await this.context.RentedCars.Include(c => c.Car).Include(rc => rc.User).ToListAsync();

            return rentedCars;
        }

        public async Task<IEnumerable<RentCar>> GetAllRentedCarsByUser(string username)
        {
            var rentedCarsByUser = await this.context.RentedCars
                .Include(c => c.Car)
                .Where(u => u.User.UserName == username)
                .ToListAsync();

            return rentedCarsByUser;
        }

        public async Task<IEnumerable<BuyCar>> GetAllSoldCars()
        {
            var soldCars = await this.context.BoughtCars.Include(c => c.Car).Include(rc => rc.User).ToListAsync();

            return soldCars;
        }
    }
}
