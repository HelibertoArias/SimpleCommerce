


using SimpleCommerce.Model.Base;

namespace SimpleCommerce.Model
{
    public class Product : IEntityBase
    {
        public long Id { get; set; }

        public bool Deleted { get; set; }

        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int Number { get; set; }

        public string Title { get; set; }

        public float Price { get; set; }
    }
}
