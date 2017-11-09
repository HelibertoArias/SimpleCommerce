using AutoMapper;
using SimpleCommerce.Model;
using SimpleCommerce.Service.ViewModel;

namespace SimpleCommerce.Service.Maps
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            var map = CreateMap<Product, ProductViewModel>();

            map.ForMember(dest => dest.Category,
                opts => opts.MapFrom(src => src.Category.Name));
        }
    }
}
