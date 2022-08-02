using GloboTicket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GloboTicket.Infrastructure.Configuration;

internal class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder
            .HasAlternateKey(v => v.VenueGuid);
        builder
            .Property(v => v.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(v => v.Address)
            .HasMaxLength(300);
    }
}
