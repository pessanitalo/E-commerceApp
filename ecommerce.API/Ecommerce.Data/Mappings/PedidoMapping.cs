using Ecommerce.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            // 1 : 1 => Pedido : Cliente
            builder.HasOne(f => f.Cliente)
                .WithOne(e => e.Pedido);

            // 1 : N => Pedido : ItemsPedido
            builder.HasMany(f => f.ItemsPedidos)
                .WithOne(p => p.Pedido)
                .HasForeignKey(p => p.PedidosId);

            builder.ToTable("Pedidos");
        }
    }
}
