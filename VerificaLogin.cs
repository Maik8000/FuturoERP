using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommerce
{
    class VerificaLogin
    {

        //Método para criptografar a senha
        public string CriptografiaSenha(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //For para ajustar o tamanho da string com o stringbuilder
            for (int i = 0;i < hash.Length;i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();            
        }
        
    }
}
