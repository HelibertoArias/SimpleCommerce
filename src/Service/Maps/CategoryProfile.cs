using AutoMapper;
using SimpleCommerce.Model;
using SimpleCommerce.Service.ViewModel;

namespace SimpleCommerce.Service.Maps
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            var map = CreateMap<Category, CategoryViewModel>();
        }
    }
}
