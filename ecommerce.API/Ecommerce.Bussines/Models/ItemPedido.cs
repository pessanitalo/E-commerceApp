namespace Ecommerce.Bussines.Models
{
    public class ItemPedido
    {
        public int PedidoId { get; set; }

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
