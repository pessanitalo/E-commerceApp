using System;

namespace Ecommerce.Bussines.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int TotalEstoque { get; set; }
        public string Fornecedor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataSaida { get; set; }


        public void AddProduto(int quantidade)
        {
            TotalEstoque += quantidade;
        }

        public void RemoveProduto(int quantidade)
        {
            TotalEstoque -= quantidade;
        }
    }
}
