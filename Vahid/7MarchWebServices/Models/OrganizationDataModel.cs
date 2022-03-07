using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _7MarchLearning.Models
{
    public partial class OrganizationDataModel : DbContext
    {
        public OrganizationDataModel()
            : base("name=OrganizationDataModel")
        {
        }

        public virtual DbSet<employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.city)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
