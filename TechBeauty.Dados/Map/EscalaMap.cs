using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class EscalaMap : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> builder)
        {

            builder.ToTable("Escala");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataHoraEntrada)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.DataHoraSaida)
                .HasColumnType("date")
                .IsRequired();
        }
    }
}