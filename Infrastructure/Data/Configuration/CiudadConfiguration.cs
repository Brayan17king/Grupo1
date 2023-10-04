using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("ciudad");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreCiudad).HasMaxLength(50);
        builder.HasOne(x => x.Departamentos).WithMany(x => x.Ciudades).HasForeignKey(x => x.IdDepartamentoFk);
    }
}