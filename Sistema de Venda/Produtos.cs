using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda
{
    internal class Produtos
    {

        private int _id;
        private string _produto;
        private string _valor;
        private string _quantidade;
        private string _sabor;
        private string _tipo;
        private string _disponivel;

        public Produtos(string produto, string valor, string quantidade, string sabor, string tipo, string disponivel)
        {
            Produto = produto;
            Valor = valor;
            Quantidade = quantidade;
            Sabor = sabor;
            Tipo = tipo;
            Disponivel = disponivel;
        }

        public Produtos(int id, string produto,string valor,string quantidade, string sabor, string tipo, string disponivel) :
             this(produto,valor,quantidade,sabor,tipo,disponivel)
        {
            _id = id;
        }
        public int Id
        {
            get { return _id; }
        }

        public string Produto
        {
            get { return _produto; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _produto = value;
            }
        }

        public string Valor
        {
            get { return _valor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _valor = value;
            }
        }

        public string Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _quantidade = value;
            }
        }


        public string Sabor
        {
            get { return _sabor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _sabor = value;
            }
        }

        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _tipo = value;
            }
        }

        public string Disponivel
        {
            get { return _disponivel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _disponivel = value;
            }
        }




    }
}
