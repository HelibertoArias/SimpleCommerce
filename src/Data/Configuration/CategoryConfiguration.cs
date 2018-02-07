


using SimpleCommerce.Model;

namespace SimpleCommerce.Data.Configuration
{
    public class CategoryConfiguration : EntityBaseConfiguration<Category>
    {
        public CategoryConfiguration()
        {

            Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

            ToTable("Category");
        }
    }
}
