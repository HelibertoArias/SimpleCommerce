

using SimpleCommerce.Model.Base;
using System.Collections.Generic;

namespace SimpleCommerce.Model
{
    public class Category: IEntityBase
    {
        public long Id { get; set; }

        public bool Deleted { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } 


    }
}
