namespace SimpleCommerce.Model.Base
{
    public interface IEntityBase
    {
        long Id { get; set; }

        bool Deleted { get; set; }
    }
}
