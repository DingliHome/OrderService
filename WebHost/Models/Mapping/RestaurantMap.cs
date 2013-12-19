using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebHost.Models.Mapping
{
    public class RestaurantMap : EntityTypeConfiguration<Restaurant>
    {
        public RestaurantMap()
        {
            // Primary Key
            this.HasKey(t => t.RestaurantId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(20);

            this.Property(t => t.City)
                .HasMaxLength(20);

            this.Property(t => t.Type)
                .HasMaxLength(20);

            this.Property(t => t.Phone)
                .HasMaxLength(20);

            this.Property(t => t.TelPhone)
                .HasMaxLength(20);

            this.Property(t => t.Mark)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Restaurant");
            this.Property(t => t.RestaurantId).HasColumnName("RestaurantId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.TelPhone).HasColumnName("TelPhone");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Mark).HasColumnName("Mark");
            this.Property(t => t.AtLestCost).HasColumnName("AtLestCost");
            this.Property(t => t.DeliveRange).HasColumnName("DeliveRange");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.IsDelivery).HasColumnName("IsDelivery");
        }
    }
}
