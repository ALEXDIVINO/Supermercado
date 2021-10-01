using System;
using System.Text.RegularExpressions;
using Supermecado.Validacao;

namespace Supermecado.Models
{
    public class PessoaFisica : Pessoa
    {
        //Atributos
        public string DataNascimento { get; set; }
        public string Genero { get; set; }
        public int Rg { get; set; }
        //
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf
        {
            get { return this.Cpf; }
            set { this.Cpf = (validateDocument(value) ? value : ""); }
        }

        public override bool validateDocument(string cpf)
        {
            return ValidarDocumentos.ValidarCpf(cpf);
        }

        public static string formatarCpf(string cpf)
        {
            return (cpf.Length == 11) ? Convert.ToInt64(cpf).ToString(@"000\,000\,000\-00") : Regex.Replace(cpf, @"[\-\,\.\ ]", "");
        }

        public static string formatarData(string nascimento)
        {
            char simbolo = nascimento.Contains("/") ? '/' : '-';
            string[] datas = nascimento.Split(simbolo);

            return $"{datas[2]}/{datas[1]}/{datas[0]}";
        }
    }
}
