using Ecommerce.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(p => p.Id);

            //1 : 1 => Pedido : Cliente
            builder.HasOne(f => f.Cliente)
                .WithOne(e => e.Pedido);

            //1 : N => Pedido : Itens
            builder.HasMany(f => f.ItensPedidos)
               .WithOne(f => f.Pedido)
               .HasForeignKey(f => f.PedidoId);
               
        }
    }
}
