using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakAwayConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BreakAwayConsole
{
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasKey(d => d.DestinationId);
            builder.Property(d => d.DestinationName).HasMaxLength(100).IsRequired();
            builder.Property(d => d.Country).HasMaxLength(100);
            builder.Property(d => d.Description).HasMaxLength(500);
            builder.Property(d => d.Photo).HasColumnType("image");
            builder.HasMany(d => d.Lodgings).WithOne(l => l.Destination);
        }
    }
}
