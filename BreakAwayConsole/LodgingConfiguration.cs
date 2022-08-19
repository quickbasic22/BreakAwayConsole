using BreakAwayConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAwayConsole
{
    public class LodgingConfiguration : IEntityTypeConfiguration<Lodging>
    {
        public void Configure(EntityTypeBuilder<Lodging> builder)
        {
            builder.Property(l => l.LodgingName)
                 .HasMaxLength(200).IsRequired();
            builder.Property(l => l.Owner)
                .HasMaxLength(200);
        }
    }
}
