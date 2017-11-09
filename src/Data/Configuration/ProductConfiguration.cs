

using SimpleCommerce.Model;
using SimpleCommerce.Model.Base;

namespace SimpleCommerce.Data.Configuration
{
    public class ProductConfiguration : EntityBaseConfiguration<Product>
    {
        public ProductConfiguration()
        {


            //HasRequired<Category>(x => x.Category)
            //    .WithMany(y => y.Products)
            //    .HasForeignKey<long>(s => s.CategoryId);

            Property(x => x.Number)
                .IsRequired();

            Property(x => x.Price)
                .IsRequired();

            Property(x => x.Title)
                .HasMaxLength(150)
                .IsRequired();

            ToTable("Product");


        }
    }
}
