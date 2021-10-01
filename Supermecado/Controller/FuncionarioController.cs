using MySqlConnector;
using System;
using Supermecado.DataBase;
using System.Windows.Forms;
using Supermecado.Models;

namespace Supermecado.Controller
{
    class FuncionarioController
    {
        private readonly static MySqlCommand cmd = new MySqlCommand();
        private readonly static Conexao conexao = new Conexao();

        public static bool Cadastrar(string nome, string cpf, string dataNacimento)
        {

            string formatNascimento = PessoaFisica.formatarData(dataNacimento);
            string formatCpf = PessoaFisica.formatarCpf(cpf);
            
            try
            {
                //Nascimento pode ser passado como string, mas precisa estar no padrão americano yyy-mm-dd
                cmd.CommandText = $"INSERT INTO funcionario (nome, cpf, nascimento) VALUES ('{nome}', '{formatCpf}', '{formatNascimento}')";
                cmd.Connection = conexao.conectarMySql();

                cmd.ExecuteNonQuery();

                conexao.desconectar();

                MessageBox.Show("Funcionario cadastradi com sucesso!");
                return true;
            } catch(Exception e)
            {
                MessageBox.Show($"Erro ao cadastrar Funcionario! \n{e.Message}");
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
