using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    class Produto
    {
        //O código de barras vai ficar em produto ou em estoque?
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCusto { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public double Tributacao { get; set; }
        /*public int CodigoBarras { get; set; }*/
    }
}
