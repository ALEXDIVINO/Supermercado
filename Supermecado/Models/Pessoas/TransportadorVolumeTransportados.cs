using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    class TransportadorVolumeTransportados :  Pessoa
    {
        public double FreteConta { get; set; }
        public int Documento { get; set; }
        public int CodigoAntt { get; set; }
        public string PlacaVeiculo { get; set; }
        public double PesoBruto { get; set; }
        public double PesoLiquido { get; set; }
        public int Numeracao { get; set; }
        public string Marca { get; set; }
        public string Especie { get; set; }
        public int Quantidade { get; set; }
        public string InscricaoEstadual { get; set; }

        public override bool validateDocument(string doc)
        {
            //TODO: Implementar para se for um cpf, chamar a verificação de cpf, se for um cnpj chamar a verificação de cnpj
            return false;
        }
    }
}
