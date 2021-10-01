using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Supermecado.Models
{
    class Usuario
    {
        public Usuario()
        {

        }

        public static string createHash(string senha)
        {
            SHA256 salt = SHA256.Create();

            return getHash(salt, senha);
        }

        private static string getHash(HashAlgorithm hashAlgorithm, string input)
        {
            //Criar o código de hash utilizando os caracteres de senha
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for(int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
