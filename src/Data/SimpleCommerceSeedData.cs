
using SimpleCommerce.Model;
 
 using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SimpleCommerce.Data
{
    public class SimpleCommerceSeedData : DropCreateDatabaseAlways<SimpleCommerceContext>
    {
        protected override void Seed(SimpleCommerceContext context)
        {
            //  GetProducts().ForEach(x => context.Products.Add(x));

            var cat = new Category() { Name = "Meat/Poultry" };
            context.Categories.Add(cat);

          
            context.SaveChanges();



            context.Products.Add(new Product()
            {
                Category = cat,
                Deleted = false,
                Number = 1000,
                Price = 39.00f,
                Title = "Alice Mutton"
            });


            var cat2 = new Category() { Name = "Seafood" };
            context.Categories.Add(cat2);

            context.SaveChanges();

            context.Products.Add(new Product()
            {
                Category = cat2,
                Deleted = false,
                Number = 1100,
                Price = 10.00f,
                Title = "Aniseed Syrup"
            });

            var cat3 = new Category() { Name = "Meat" };
            context.Categories.Add(cat3);
            context.SaveChanges();


            context.Products.Add(new Product()
            {
                Category = cat3,
                Deleted = false,
                Number = 1200,
                Price = 19.00f,
                Title = "Chang"
            });


            context.SaveChanges();

        }

        private static List<Product> GetProducts()
        {
            return new List<Product>(){
                new Product(){
                   CategoryId = 1,
                    Deleted = false,
                    Number = 1000,
                    Price = 39.00f,
                    Title = "Alice Mutton"
                },

                new Product(){
                    CategoryId = 2,
                    Deleted = false,
                    Number = 1100,
                    Price = 10.00f,
                    Title = "Aniseed Syrup"
                },

                new Product(){
                    CategoryId = 3,
                    Deleted = false,
                    Number = 1200,
                    Price = 19.00f,
                    Title = "Chang"
                },


                
            };
        }
    }
}
