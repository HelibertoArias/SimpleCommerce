using System.Collections.Generic;

namespace SimpleCommerce.Service.ViewModel
{
    public class ProductEditViewModel
    {
        public ProductViewModel Product { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }
}
