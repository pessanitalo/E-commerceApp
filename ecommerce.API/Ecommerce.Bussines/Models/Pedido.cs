using System.Collections.Generic;

namespace Ecommerce.Bussines.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public double TotalPedido { get; set; }
        public Pagamento Pagamento { get; set; }
        public  Cliente Cliente { get; set; }
        public IEnumerable<ItemPedido> ItemsPedidos { get; set; }

    }
}
