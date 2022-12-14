using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venda
{
    internal class DAO
    {
        private SqlConnection sqlcon;

        string strCon = @"Data Source=" + Environment.MachineName +
               @"\SQLEXPRESS;Initial Catalog=Vendas;Integrated Security=true";
        private string strSql = string.Empty;

        public DAO()
        {

        }
        public void Inserir(Funcionario func)
        {
            strSql = "insert into funcionario (func_nome, func_telefone, func_cpf, func_email,func_data_nasc, func_end, func_usuario,func_senha, admin) values(@Nome, @Telefone, @Cpf, @Email, @Data, @Endereco, @Usuario, @Senha, @Admin)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = func.Nome;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = func.Telefone;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = func.Email;
            comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = func.Cpf;
            comando.Parameters.Add("@Data", SqlDbType.VarChar).Value = func.Data_nasc;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = func.Endereco;
            comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = func.Usuario;
            comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = func.Senha;
            comando.Parameters.Add("@Admin", SqlDbType.VarChar).Value = func.Admin;
            



            sqlcon.Open();

            try
            {   

                //Executa query definida acima.
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void Excluir(int idUsuario)
        {
            strSql = @"DELETE FROM funcionario WHERE Id = @Id";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.AddWithValue("@Id", idUsuario);

            sqlcon.Open();

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void Atualizar(Funcionario func)
        {
            strSql = @"UPDATE funcionario SET func_nome = @Nome, func_telefone = @Telefone, func_cpf = @Cpf, 
            func_email = @Email, func_data_nasc = @Data_nasc, func_end = @Endereco, func_usuario = @Usuario, func_senha = @Senha, admin = @Admin WHERE id = @Id";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            sqlcon.Open();

            comando.Parameters.AddWithValue("@Id", func.Id);
            comando.Parameters.AddWithValue("@Nome", func.Nome);
            comando.Parameters.AddWithValue("@Telefone", func.Telefone);
            comando.Parameters.AddWithValue("@Cpf", func.Cpf);
            comando.Parameters.AddWithValue("@Email", func.Email);
            comando.Parameters.AddWithValue("@Data_nasc", func.Data_nasc);
            comando.Parameters.AddWithValue("@Endereco", func.Endereco);
            comando.Parameters.AddWithValue("@Usuario", func.Usuario);
            comando.Parameters.AddWithValue("@Senha", func.Senha);
            comando.Parameters.AddWithValue("@Admin", func.Admin);
 

            try
            {
                comando.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public List<Funcionario> ListarTodosUsuarios()
        {

            strSql = "SELECT * FROM funcionario";
            sqlcon = new SqlConnection(strCon);

            sqlcon.Open();

            SqlCommand controle = new SqlCommand(strSql, sqlcon);



            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();
            try
            {
                SqlDataReader rd = controle.ExecuteReader();

                while (rd.Read())
                {
                    Funcionario cliente = new Funcionario((int)rd["id"], (string)rd["func_nome"], (string)rd["func_telefone"], (string)rd["func_cpf"],
                       (string)rd["func_email"], (string)rd["func_data_nasc"], (string)rd["func_end"], (string)rd["func_usuario"], (string)rd["func_senha"], (string)rd["admin"]);
                    listaDeFuncionarios.Add(cliente);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return listaDeFuncionarios;
        }

        public string EntrarLogin(Funcionario login)
        {
            string admin = null;

            strSql = @"SELECT admin FROM funcionario WHERE func_usuario = @Usuario AND func_senha = @Senha";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            sqlcon.Open();

            comando.Parameters.AddWithValue("@Usuario", login.Usuario);
            comando.Parameters.AddWithValue("@Senha", login.Senha);

            try
            {

                SqlDataReader rd = comando.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    admin = (string)rd["admin"];
                }
                rd.Close();
            }
            catch (Exception)
            {
                throw new Exception("Erro: Usuario não encontrado!");
            }
            finally
            {
                sqlcon.Close();
            }

            return admin;
        }

        public List<Produtos> ListarTodosProdutos()
        {

            strSql = "SELECT * FROM produtos";
            sqlcon = new SqlConnection(strCon);

            sqlcon.Open();

            SqlCommand controle = new SqlCommand(strSql, sqlcon);



            List<Produtos> listarProdutos = new List<Produtos>();
            try
            {
                SqlDataReader rd = controle.ExecuteReader();

                while (rd.Read())
                {
                    Produtos proj = new Produtos((int)rd["id_produto"], (string)rd["nome_produto"], (decimal)rd["valor_produto"], (int)rd["quant_produto"],
                       (string)rd["sabor"], (string)rd["tipo"],(string)rd["imagem"], (string)rd["disponivel"]);
                    listarProdutos.Add(proj);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return listarProdutos;
        }

        public void ExcluirProduto(int idproduto)
        {
            strSql = @"DELETE FROM produtos WHERE id_produto = @Id";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.AddWithValue("@Id", idproduto);

            sqlcon.Open();

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void InserirProduto(Produtos proj)
        {
            strSql = "insert into produtos  values(@Nome, @Valor, @Quant, @Sabor, @Tipo,@Imagem, @Disponivel)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = proj.Produto;
            comando.Parameters.Add("@Valor", SqlDbType.Decimal).Value = proj.Valor;
            comando.Parameters.Add("@Quant", SqlDbType.Int).Value = proj.Quantidade;
            comando.Parameters.Add("@Sabor", SqlDbType.VarChar).Value = proj.Sabor;
            comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = proj.Tipo;
            comando.Parameters.Add("@Imagem", SqlDbType.VarChar).Value = proj.Imagem;
            comando.Parameters.Add("@Disponivel", SqlDbType.VarChar).Value = proj.Disponivel;





            sqlcon.Open();

            try
            {

                //Executa query definida acima.
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir produto no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void AtualizarProduto(Produtos proj)
        {
            strSql = @"UPDATE produtos SET nome_produto = @Nome, valor_produto = @Valor, quant_produto = @Quant, 
            sabor = @Sabor, tipo = @Tipo, imagem = @Imagem, disponivel = @Disponivel WHERE id_produto = @Id";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            sqlcon.Open();

            comando.Parameters.AddWithValue("@Id", proj.Id);
            comando.Parameters.AddWithValue("@Nome", proj.Produto);
            comando.Parameters.AddWithValue("@Valor", proj.Valor);
            comando.Parameters.AddWithValue("@Quant", proj.Quantidade);
            comando.Parameters.AddWithValue("@Sabor", proj.Sabor);
            comando.Parameters.AddWithValue("@Tipo", proj.Tipo);
            comando.Parameters.AddWithValue("@Imagem", proj.Imagem);
            comando.Parameters.AddWithValue("@Disponivel", proj.Disponivel);



            try
            {
                comando.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public List<venda> ListarTodasVendas()
        {

            strSql = "SELECT * FROM venda";
            sqlcon = new SqlConnection(strCon);

            sqlcon.Open();

            SqlCommand controle = new SqlCommand(strSql, sqlcon);



            List<venda> listarVendas = new List<venda>();
            try
            {
                SqlDataReader rd = controle.ExecuteReader();

                while (rd.Read())
                {
                    venda proj = new venda((int)rd["id_pedido"], (int)rd["quant_produto"], (decimal)rd["valor_total"], (DateTime)rd["data_pedido"],
                       (int)rd["id_prod"]);
                    listarVendas.Add(proj);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return listarVendas;
        }
        public void InserirVendas( venda proj)
        {
            strSql = "insert into venda  values(@Quantidade, @Valor, @Data, @IdProd)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = proj.Quantidade;
            comando.Parameters.Add("@Valor", SqlDbType.Decimal).Value = proj.ValorTotal;
            comando.Parameters.Add("@Data", SqlDbType.DateTime).Value = proj.Data;
            comando.Parameters.Add("@IdProd", SqlDbType.Int).Value = proj.IdProd;






            sqlcon.Open();

            try
            {

                //Executa query definida acima.
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir venda no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void ExcluirVenda(int idvenda)
        {
            strSql = @"DELETE FROM venda WHERE id_pedido = @Id";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.AddWithValue("@Id", idvenda);

            sqlcon.Open();

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void AtualizarVenda(venda proj)
        {
            strSql = @"UPDATE venda SET quant_produto = @Quant, valor_total = @Valor, data_pedido = @Data, 
            id_prod = @ID WHERE id_pedido = @Id";
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            sqlcon.Open();

            comando.Parameters.AddWithValue("@Quant", proj.Quantidade);
            comando.Parameters.AddWithValue("@Valor", proj.ValorTotal);
            comando.Parameters.AddWithValue("@Data", proj.Data);
            comando.Parameters.AddWithValue("@ID", proj.IdProd);




            try
            {
                comando.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar");
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public List<Fechamento> ListarFechamento()
        {

            strSql = @"SELECT fechamento.id_fechamento, fechamento.Itens, fechamento.ValorTotal,fechamento.pagamento, venda.data_pedido FROM fechamento INNER JOIN venda ON fechamento.id_pedido = venda.id_pedido";
            sqlcon = new SqlConnection(strCon);

            sqlcon.Open();

            SqlCommand controle = new SqlCommand(strSql, sqlcon);



            List<Fechamento> listarVendas = new List<Fechamento>();
            try
            {
                SqlDataReader rd = controle.ExecuteReader();

                while (rd.Read())
                {
                    Fechamento proj = new Fechamento((int)rd["id_fechamento"], (int)rd["Itens"], (decimal)rd["ValorTotal"],(string)rd["pagamento"], (DateTime)rd["data_pedido"]);
                    listarVendas.Add(proj);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return listarVendas;
        }

        public void InserirFechamento(Fechamento proj)
        {
            strSql = "insert into fechamento  values(@Itens, @Valor,@Pagamento, @IdProd)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@Itens", SqlDbType.Int).Value = proj.Itens;
            comando.Parameters.Add("@Valor", SqlDbType.Decimal).Value = proj.ValorTotal;
            comando.Parameters.Add("@Pagamento", SqlDbType.VarChar).Value = proj.Pagamento;
            comando.Parameters.Add("@IdProd", SqlDbType.Int).Value = proj.Ids;


            sqlcon.Open();

            try
            {

                //Executa query definida acima.
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir venda no banco.\n" + err.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

    }
}
