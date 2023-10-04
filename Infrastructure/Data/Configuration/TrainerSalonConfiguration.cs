using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure.Data.Configuration;

public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
{
    public void Configure(EntityTypeBuilder<TrainerSalon> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("trainersalon");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.HasOne(x => x.Personas).WithMany(x => x.TrainerSalones).HasForeignKey(x => x.IdPersonaFk);
        builder.HasOne(x => x.Salones).WithMany(x => x.TrainerSalones).HasForeignKey(x => x.IdSalonFk);
    }
}