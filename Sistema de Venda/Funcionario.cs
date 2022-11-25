using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda
{
    internal class Funcionario
    {
        private int _id;
        private string _nome;
        private string _telefone;
        private string _email;
        private string _data_nasc;
        private string _endereco;
        private string _cpf;
        private string _usuario;
        private string _senha;



        public Funcionario(string nome, string telefone, string cpf, string email, string data_nasc, string endereco, string usuario, string senha)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Data_nasc = data_nasc;
            Cpf = cpf;
            Usuario = usuario;
            Senha = senha;

        }
        public Funcionario(int id, string nome, string telefone, string cpf, string email, string data_nasc, string endereco, string usuario, string senha) :
            this(nome, telefone, cpf,email, data_nasc, endereco, usuario, senha)
        {
            _id = id;
        }
        public int Id
        {
            get { return _id; }
        }

        //Validação do Nome.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }

        //Validação do Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;
            }
        }

        //Validação do Celular
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _email = value;
            }
        }

        //Validação do endereço.
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _endereco = value;
            }
        }

        public string Data_nasc
        {
            get { return _data_nasc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _data_nasc = value;
            }
        }
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                ValidarCpf validarCpf = new ValidarCpf();
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O email informado não é um texto válido");
                if (value.Length < 11)
                    throw new Exception("O tamanho está errado!");
                if (!validarCpf.ValidaCpf(value))
                    throw new Exception("O cpf informado é inválido!");
                _cpf = value;
            }
        }
        
        public string Usuario
        {
            get { return _usuario; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome de usuario informado não é um texto válido");
                _usuario = value;
            }
        }
        //Validação do Senha
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informada não é um texto válido");
                _senha = value;
            }
        }

        
    }
}
