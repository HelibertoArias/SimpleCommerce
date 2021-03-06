﻿
using SimpleCommerce.Model;

using System.Collections.Generic;

namespace SimpleCommerce.Repository.Repositories.Interfaces
{
    public interface IProductRepository 
    {
        ICollection<Product> Get();

        Product Find(long id);

        void Create(Product item);

        void Update(Product id);

        void Delete(long id);

    }


}
