using System.Collections.Generic;

namespace Ecommerce.Bussines.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal TotalPedido { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; } = new List<ItemPedido>();


        public void AddItem(ItemPedido pedido)
        {
            ItensPedidos.Add(pedido);
        }

        public void RemoveItem(ItemPedido pedido)
        {
            ItensPedidos.Remove(pedido);
        }

        public double Total()
        {
            double sum = 0;
            foreach (ItemPedido item in ItensPedidos)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
    }
}
