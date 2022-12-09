using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_de_Venda
{
    internal class criptografia
    {
        public string crip(string cripto)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cripto));

            byte[] resultado = md5.Hash;

            StringBuilder Construtor = new StringBuilder();
            for (int i = 0; i < resultado.Length; i++)
            {

                Construtor.Append(resultado[i].ToString("x2"));
            }

            return Construtor.ToString();
        }
    }
}
