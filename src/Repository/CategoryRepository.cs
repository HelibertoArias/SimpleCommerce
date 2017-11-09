using System.Linq;
using System.Collections.Generic;
using SimpleCommerce.Model;
using SimpleCommerce.Repository.Repositories.Interfaces;
using SimpleCommerce.Data;

namespace SimpleCommerce.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        SimpleCommerceContext ctx = new SimpleCommerceContext();




        public ICollection<Category> Get()
        {
            var data = ctx.Categories.ToList();

            return data;
        }
    
    }
}
