using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WebHost.Models.Mapping;

namespace WebHost.Models
{
    public partial class OrderDBContext : DbContext
    {
        static OrderDBContext()
        {
            Database.SetInitializer<OrderDBContext>(new DropCreateDatabaseIfModelChanges<OrderDBContext>());
        }

        public OrderDBContext()
            : base("Name=OrderDBContext")
        {
          
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new RestaurantMap());
        }
    }
}
