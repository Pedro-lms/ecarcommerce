using ecommerce.src.Data;

namespace ecommerce.src.Services.Implementations
{
    public class DataService
    {

        protected readonly VehiclePortalDbContext context;

        public DataService(VehiclePortalDbContext context)
        {
            this.context = context;
        }
    }
}
