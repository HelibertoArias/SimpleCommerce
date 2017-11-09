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

        SimpleCommerceContext ctx = new SimpleCommerceContext();


        public void Create(Product item)
        {
            ctx.Products.Add(item);
        }

        public void Delete(long id)
        {
            var item = Find(id);
            ctx.Entry(item).State = EntityState.Modified;
        }

        public Product Find(long id)
        {
            var item = ctx.Products.Find(id);
            return item;
        }

        public ICollection<Product> Get()
        {
            var item = ctx.Products.Where(x=>x.Deleted==true).ToList();
            return item;
        }

        public void Update(Product item)
        {
            ctx.Entry(item).State = EntityState.Modified;
        }
    }
}
