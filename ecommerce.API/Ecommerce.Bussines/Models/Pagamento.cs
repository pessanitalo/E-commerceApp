using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Bussines.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string TipoPagamento { get; set; }
        public double ValorTotal { get; set; }
        public double Desconto { get; set; }
    }
}
