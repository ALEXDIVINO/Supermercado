using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    class Estoque
    {
        public int Id { get; set; }
        public int qtdEstoque { get; set; }
        public int qtdPrateleira { get; set; }
        public int qtdMin { get; set; }
        public int qtdMax { get; set; }
        public DateTime proximaContagem { get; set; }
    }
}
