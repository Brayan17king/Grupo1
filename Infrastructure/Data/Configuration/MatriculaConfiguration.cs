using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("matricula");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.HasOne(x => x.Personas).WithMany(x => x.Matriculas).HasForeignKey(x => x.IdPersonaFk);
        builder.HasOne(x => x.Salones).WithMany(x => x.Matriculas).HasForeignKey(x => x.IdSalonFk);
    }
}