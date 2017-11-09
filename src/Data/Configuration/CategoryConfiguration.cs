


using SimpleCommerce.Model;
using SimpleCommerce.Model.Base;

namespace SimpleCommerce.Data.Configuration
{
    public class CategoryConfiguration: EntityBaseConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            //HasMany(x => x.Products)
            //    .WithRequired()
            //    .HasForeignKey(y => y.CategoryId);

            Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

             ToTable("Category");
        }
    }
}
