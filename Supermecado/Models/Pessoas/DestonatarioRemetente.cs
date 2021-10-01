using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    class DestinatarioRemetente : Pessoa
    {
        //Atributos
        public int Documento { get; set; }
        public DateTime DataEmissao { get; set; }
        public string IncricaoEstadual { get; set; }
        public DateTime dataHoraSaida { get; set; }
        //
        public string Telefone { get; set; }

        public override bool validateDocument(string doc)
        {
            //TODO: Implementar para se for um cpf, chamar a verificação de cpf, se for um cnpj chamar a verificação de cnpj
            return false;
        }
    }
}
