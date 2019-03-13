using System.Data.Entity;
using TesteUDS.Models;

namespace TesteUDS
{
    public class EFContext : DbContext
    {


        public static EFContext Build()
        {
            return new EFContext();
        }


        public EFContext() : base("TesteUDS.Properties.Settings.Connect")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            base.OnModelCreating(dbModelBuilder);
            dbModelBuilder.Entity<mPizza>().ToTable("Pizza");
            dbModelBuilder.Entity<mSize>().ToTable("Size");
            dbModelBuilder.Entity<mOrder>().ToTable("Order");
            dbModelBuilder.Entity<mExtra>().ToTable("Extra");
            dbModelBuilder.Entity<mExtraOnOrder>().ToTable("ExtraOnOrder");
        }


        public DbSet<mPizza> mPizza { get; set; }
        public DbSet<mSize> mSize { get; set; }
        public DbSet<mOrder> mOrder { get; set; }
        public DbSet<mExtra> mExtra { get; set; }
        public DbSet<mExtraOnOrder> mExtraOnOrder { get; set; }
    }
}