namespace Ecommerce.Bussines.Models
{
    public class Cliente : Pessoa
    {
        public string Email { get; set; }
        public Pedido Pedido { get; set; }
    }
}
