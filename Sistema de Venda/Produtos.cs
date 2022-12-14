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
        private decimal _valor;
        private int _quantidade;
        private string _sabor;
        private string _tipo;
        private string _imagem;
        private string _disponivel;

        public Produtos(string produto, decimal valor, int quantidade, string sabor, string tipo,string imagem, string disponivel)
        {
            Produto = produto;
            _valor = valor;
            _quantidade = quantidade;
            Sabor = sabor;
            Tipo = tipo;
            Imagem = imagem;
            Disponivel = disponivel;
        }

        public Produtos(int id, string produto,decimal valor,int quantidade, string sabor, string tipo,string imagem, string disponivel) :
             this(produto,valor,quantidade,sabor,tipo,imagem,disponivel)
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

        public decimal Valor
        {
            get { return _valor; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
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
        public string Imagem
        {
            get { return _imagem; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _imagem = value;
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
