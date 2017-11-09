

using SimpleCommerce.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SimpleCommerce.Data.Configuration
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(x => x.Id)
           .Property(x => x.Id)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
