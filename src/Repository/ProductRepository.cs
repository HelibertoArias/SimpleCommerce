using System;
using System.Linq;
using System.Collections.Generic;
using SimpleCommerce.Model;
using SimpleCommerce.Repository.Repositories.Interfaces;
using SimpleCommerce.Data;
using System.Data.Entity;

namespace SimpleCommerce.Repository
{
    public class ProductRepository : IProductRepository
    {

       private SimpleCommerceContext _ctx;

        public ProductRepository(SimpleCommerceContext ctx)
        {
            _ctx = ctx;
        }


        public void Create(Product item)
        {
            _ctx.Products.Add(item);
        }

        public void Delete(long id)
        {
            var item = Find(id);
            _ctx.Entry(item).State = EntityState.Modified;
        }

        public Product Find(long id)
        {
            var item = _ctx.Products.Find(id);
            return item;
        }

        public ICollection<Product> Get()
        {
            var item = _ctx.Products.Where(x=>x.Deleted==false).ToList();
            return item;
        }

        public void Update(Product item)
        {
            _ctx.Entry(item).State = EntityState.Modified;
        }
    }
}
