using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ValorPagamento)
            .HasColumnType("decimal(6,2)")
            .IsRequired();

            builder.Property(x => x.FechamentoDia)
            .HasColumnType("decimal(6,2)")
            .IsRequired();

            builder.Property(x => x.Caixa)
            .HasColumnType("decimal(7,2)")
            .IsRequired();

            builder.HasMany<Pagamento>(x => x.ValorPagamento)
            .WithOne(x => x.cliente)
            .HasForeignKey(x => x.ClienteID);
        }
    }
}
