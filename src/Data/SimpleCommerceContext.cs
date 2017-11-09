

using SimpleCommerce.Data.Configuration;
using SimpleCommerce.Model;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;

namespace SimpleCommerce.Data
{
    public class SimpleCommerceContext : DbContext
    {
        public SimpleCommerceContext() : base("name = SimpleCommerceAppConnectionString")
        {
            Database.SetInitializer(new SimpleCommerceSeedData());

            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = true;
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            //                        .Where(type => !String.IsNullOrEmpty(type.Namespace))
            //                        .Where(type => type.BaseType != null && type.BaseType.IsGenericType
            //                            && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.Configurations.Add(configurationInstance);
            //}

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());



            base.OnModelCreating(modelBuilder);
        }

        //public virtual void Commit()
        //{
        //    base.SaveChanges();
        //}
    }
}