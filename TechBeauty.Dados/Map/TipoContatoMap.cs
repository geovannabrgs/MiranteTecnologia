using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
   public class TipoContatoMap : IEntityTypeConfiguration<TipoContato>
    {
        public void Configure(EntityTypeBuilder<TipoContato> builder)
        {
            builder.ToTable("TipoContato");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.HasMany<Contato>(r => r.Contatos)
                .WithOne(c => c.Tipo)
                .HasForeignKey(c => c.TipoContatoID);

        }
    }
}
