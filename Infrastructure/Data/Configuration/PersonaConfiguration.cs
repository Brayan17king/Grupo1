using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("persona");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombrePersona).HasMaxLength(50);
        builder.Property(x => x.ApellidoPersona).HasMaxLength(50);

        builder.HasOne(x => x.Ciudades).WithMany(x => x.Personas).HasForeignKey(x => x.IdCiudadFk);
        builder.HasOne(x => x.TipoPersonas).WithMany(x => x.Personas).HasForeignKey(x => x.IdTipoPersonaFk);
    }
}