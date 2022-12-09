using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda
{
    internal class venda
    {

        private int _id;
        private string _valor;
        private int _id_func;
        private int _id_prod;
        private string _data;






        public venda(string valor, string data )
        {

            Valor = valor;
            Data = data;


        }

        public venda(int id, string valor, int id_func, int id_prod, string data) :
            this(valor, data)
        {
            _id = id;
            _id_func = id_func;
            _id_func = id_prod;
        }


        public int Id
        {
            get { return _id; }
        }

        public int Id_Func
        {
            get { return _id_func; }
        }

        public int Id_Produto
        {
            get { return _id_prod; }
        }

        //Validação do Nome.
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

        public string Data
        {
            get { return _data; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _data = value;
            }
        }

    }
}

