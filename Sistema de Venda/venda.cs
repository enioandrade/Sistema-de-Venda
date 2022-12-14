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
        private int _quantidade;
        private decimal _valorTotal;
        private DateTime _data;
        private int _idProd;






        public venda(int quantidade, decimal valorTotal, DateTime data, int idProd )
        {
            _quantidade = quantidade;
            _valorTotal = valorTotal;
            _data = data;
            _idProd = idProd;


        }

        public venda(int id, int quantidade, decimal valorTotal, DateTime data, int idProd) :
            this(quantidade,valorTotal, data,idProd)
        {
            _id = id;

        }


        public int Id
        {
            get { return _id; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public decimal ValorTotal
        {
            get { return _valorTotal; }
        }

        //Validação do Nome.
        public DateTime Data
        {
            get { return _data; }
        }

        public int IdProd
        {
            get { return _idProd; }
        }

    }
}

