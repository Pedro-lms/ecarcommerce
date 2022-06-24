using ecommerce.src.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ecommerce.src.Data
{
    public class VehiclePortalDbContext : IdentityDbContext<VehiclePortalUser>
    {
        public VehiclePortalDbContext(DbContextOptions<VehiclePortalDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<BuyCar> BoughtCars { get; set; }

        public DbSet<RentCar> RentedCars { get; set; }
    }

}