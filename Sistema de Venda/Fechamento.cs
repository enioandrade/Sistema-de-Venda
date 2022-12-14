using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda
{


        internal class Fechamento
        {

            private int _id;
            private int _id_pedido;
            private int _itens;
            private decimal _valorTotal;
            private string _pagamento;
            private DateTime _data;
            


            public Fechamento(int itens, decimal valorTotal,string pagamento, int ids)
            {
                _id_pedido = ids;
                _itens = itens;
                _valorTotal = valorTotal;
                 Pagamento = pagamento;
                
                

            }

            public Fechamento(int id, int itens, decimal valorTotal,string pagamento, int ids) :
                 this( itens, valorTotal,pagamento, ids)
            {
                _id = id;
            }


        public Fechamento(int itens, decimal valorTotal,string pagamento, DateTime data)
        {
            
            _itens = itens;
            _valorTotal = valorTotal;
            Pagamento = pagamento;
            _data = data;


        }

        public Fechamento(int id, int itens, decimal valorTotal, string pagamento, DateTime data) :
             this( itens, valorTotal,pagamento, data)
        {
            _id = id;
        }
        public int Id
            {
                get { return _id; }
            }

            public int Ids
            {
                get { return _id_pedido; }
            }

   

            public int Itens
            {
                get { return _itens; }
            }

            public decimal ValorTotal
            {
                get { return _valorTotal; }
            }

        public string Pagamento
        {
            get { return _pagamento; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _pagamento = value;
            }
        }

        public DateTime Data
            {
                get { return _data; }
            }







        }
}

