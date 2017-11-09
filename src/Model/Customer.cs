


using SimpleCommerce.Model.Base;

namespace SimpleCommerce.Model
{
    public    class Customer : IEntityBase
    {
        public long Id { get; set; }

        public bool Deleted { get; set; }
    }
}
