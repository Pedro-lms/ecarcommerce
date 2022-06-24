using AutoMapper;
using ecommerce.src.Models;
using ecommerce.src.ServiceModels;

namespace ecommerce.src.Common.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            this.CreateMap<Car, CarBindingModel>().ReverseMap().ForMember(m => m.Rating, opt => opt.Ignore());
            this.CreateMap<Car, CarDetailsViewModel>();
            this.CreateMap<BuyCar, BuyCarBindingModel>();
            this.CreateMap<RentCar, RentCarBindingModel>();
            this.CreateMap<AddFoundServiceModel, AddFoundBindingModel>();
            this.CreateMap<EditCarServiceModel, EditCarViewModel>();
            this.CreateMap<CompareCarServiceModel, CompareCarViewModel>();
        }
    }
}
