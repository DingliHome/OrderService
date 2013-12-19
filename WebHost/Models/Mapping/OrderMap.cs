using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebHost.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.RestaurantId).HasColumnName("RestaurantId");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerId);
            this.HasRequired(t => t.Restaurant)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.RestaurantId);

        }
    }
}
