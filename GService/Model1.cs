namespace GService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        //public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CommonTypes.Customer> Customers { get; set; }
        public virtual DbSet<CommonTypes.Inventory> Inventories { get; set; }
        public virtual DbSet<CommonTypes.Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
