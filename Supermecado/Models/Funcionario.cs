using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    class Funcionario : PessoaFisica
    {
        public string Setor { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int Pis { get; set; }
        //public int NumeroFuncionario { get; set; } //Gerar automaticamente? Ou utilizar o número do ID?
        public string Status { get; set; } // Tipos de status: contratado, demitido, afastado (coisas do tipo)
    }
}
