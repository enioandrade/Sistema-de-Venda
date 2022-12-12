﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_de_Venda
{

    public class Criptografia
    {
        public string EncodeToBase64(string texto)
        {
            try
            {
                byte[] textoAsBytes = Encoding.ASCII.GetBytes(texto);
                string resultado = System.Convert.ToBase64String(textoAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //converte de base64 para texto
        public string DecodeFrom64(string dados)
        {
            try
            {
                byte[] dadosAsBytes = System.Convert.FromBase64String(dados);
                string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //internal class criptografia
        //{
        //    public string crip(string cripto)
        //    {
        //        MD5 md5 = new MD5CryptoServiceProvider();

        //        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cripto));

        //        byte[] resultado = md5.Hash;

        //        StringBuilder Construtor = new StringBuilder();
        //        for (int i = 0; i < resultado.Length; i++)
        //        {

        //            Construtor.Append(resultado[i].ToString("x2"));
        //        }

        //        return Construtor.ToString();
        //    }
        //}
    }
}
