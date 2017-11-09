using SimpleCommerce.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommerce.Service
{
    public interface IProductService
    {
        ListProductViewModel GetProducts();

        ProductEditViewModel GetProduct(long id);

        List<CategoryViewModel> GetCategories();

        void AddProduct(ProductViewModel viewModel);

        void UpdateProduct(ProductViewModel viewModel);



    }
}
