using System.Linq;
using System.Collections.Generic;
using SimpleCommerce.Model;
using SimpleCommerce.Repository.Repositories.Interfaces;
using SimpleCommerce.Data;

namespace SimpleCommerce.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private SimpleCommerceContext _ctx;


        public CategoryRepository(SimpleCommerceContext ctx)
        {
            _ctx = ctx;
        }

        public ICollection<Category> Get()
        {
            var data = _ctx.Categories.ToList();

            return data;
        }
    
    }
}
