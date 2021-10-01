using Supermecado.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    public class PessoaJuridica : Pessoa
    {
        //Atributos
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public List<PessoaFisica> Responsaveis { get; set; }
        public List<Categoria> Categorias { get; set; }
        //
        public string Email { get; set; }
        public string Telefone { get; set; }

        public override bool validateDocument(string cnpj)
        {
            return ValidarDocumentos.ValidarCnpj(cnpj);
        }
    }

    public class Categoria
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string descricao { get; set; }


    }
}
