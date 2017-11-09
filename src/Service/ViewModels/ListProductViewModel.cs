using System.Collections.Generic;

namespace SimpleCommerce.Service.ViewModel
{
    public class ListProductViewModel
    {
        public ICollection<ProductViewModel> Products { get; set; }
    }
}
