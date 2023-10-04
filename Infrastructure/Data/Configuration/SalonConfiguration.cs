using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class SalonConfiguration : IEntityTypeConfiguration<Salon>
{
    public void Configure(EntityTypeBuilder<Salon> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("salon");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreSalon).HasMaxLength(50);
        builder.Property(x => x.CapacidadSalon).HasColumnType("int");

        
    }
}