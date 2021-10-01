using MySqlConnector;
using Supermecado.DataBase;
using Supermecado.Models;
using System;

namespace Supermecado.Controller
{
    class LoginController
    {
        private static MySqlDataReader dataReader;
        private readonly static MySqlCommand cmd = new MySqlCommand();
        private readonly static Conexao conexao = new Conexao();

        public LoginController()
        {

        }

        private static bool verifyPass(string senhaDigitada, string senhaHash)
        {
            senhaDigitada = Usuario.createHash(senhaDigitada);
            
            return senhaDigitada.Equals(senhaHash);
        }

        public static bool verifyLogin(string email, string senha)
        {
            try
            {
                string senhaRead = "";
                cmd.CommandText = "SELECT email, senha FROM login WHERE email = @email"; ;
                cmd.Connection = conexao.conectarMySql();
                cmd.Parameters.AddWithValue("@email", email);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    senhaRead = dataReader.GetString(1);
                }

                if (senhaRead == "") return false;

                conexao.desconectar();

                return verifyPass(senha, senhaRead);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro no login! \n {e}");
                return false;
            }
        }
    }
}
