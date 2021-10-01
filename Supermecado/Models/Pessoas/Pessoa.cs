using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    public abstract class Pessoa
    {
        //Atribitos
        public int id { get; private set; }
        public string Nome { get; set; }
        /*public string Email { get; set; }
        public string Telefone { get; set; }*/
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Cep { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id, string nome, string endereco, string cidade, string uf, int cep)
        {
            this.id = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Uf = uf;
            this.Cep = cep;
        }

        public abstract bool validateDocument(string doc);
    }
}
