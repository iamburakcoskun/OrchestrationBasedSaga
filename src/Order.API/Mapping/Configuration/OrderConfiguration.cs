using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Order.API.Mapping.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Models.Order>
    {
        public void Configure(EntityTypeBuilder<Models.Order> builder)
        {
            builder
                .HasMany(o => o.Items)
                .WithOne(o => o.Order);
        }
    }
}
