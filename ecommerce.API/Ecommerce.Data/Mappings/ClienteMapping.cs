using Ecommerce.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Telefone)
                .IsRequired()
                .HasColumnType("char(11)");

            builder.Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnType("char(8)");

            builder.Property(p => p.Cpf)
                .IsRequired()
                .HasColumnType("char(11)");

            builder.Property(p => p.Rg)
                .IsRequired()
                .HasColumnType("char(9)");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(50)"); 

            builder.ToTable("Clientes");
        }
    }
}
