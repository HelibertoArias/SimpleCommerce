
using SimpleCommerce.Model;

using System.Collections.Generic;

namespace SimpleCommerce.Repository.Repositories.Interfaces
{
    public interface ICategoryRepository 
    {
        ICollection<Category> Get();
    }
}
