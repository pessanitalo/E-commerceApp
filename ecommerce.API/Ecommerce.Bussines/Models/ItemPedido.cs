namespace Ecommerce.Bussines.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public int PedidosId { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
