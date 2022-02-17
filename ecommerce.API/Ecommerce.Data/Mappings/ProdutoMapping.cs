using Ecommerce.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Preco)
                .IsRequired();
                

            builder.Property(p => p.Fornecedor)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(p => p.DataCadastro)
              .HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
              

            builder.Property(p => p.DataSaida)
              .HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();


            builder.ToTable("Produtos");
        }
    }
}
