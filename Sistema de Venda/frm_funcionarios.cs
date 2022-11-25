using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venda
{
    public partial class frm_funcionarios : Form
    {

        private int Id;
        public frm_funcionarios()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        string strCon = @"Data Source=" + Environment.MachineName +
                       @"\SQLEXPRESS;Initial Catalog=Vendas;Integrated Security=true";
        private string strSql = string.Empty;

        private void AtualizarListView()
        {
            ltv_dados.Items.Clear();
            DAO Dao = new DAO();

            List<Funcionario> funcionarios = Dao.ListarTodosUsuarios();
            if (funcionarios.Count > 0)
            {
                foreach (var user in funcionarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Cpf);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Data_nasc);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Usuario);
                    lv.SubItems.Add(user.Senha);
                    ltv_dados.Items.Add(lv);
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Funcionario func;
                func = new Funcionario(txt_nome.Text, txt_telefone.Text, txt_cpf.Text, txt_email.Text, txt_data_nasc.Text, txt_end.Text, txt_usuario.Text, txt_senha.Text);
                DAO usuario = new DAO();

               
                    usuario.Inserir(func);

                MessageBox.Show("Cadastro Efetuado com Sucesso");
                AtualizarListView();
                LimparCampos();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
          
        }


        private void LimparCampos()
        {
            txt_cpf.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_data_nasc.Clear();
            txt_end.Clear();
            txt_id.Clear();
            txt_usuario.Clear();
            txt_senha.Clear();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void frm_funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DAO usuario = new DAO();
                    usuario.Excluir(Id);
                    MessageBox.Show("Funcionario excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "ERRO AO EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AtualizarListView();
            LimparCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario func;
                func = new Funcionario(Id, txt_nome.Text, txt_telefone.Text, txt_cpf.Text, txt_email.Text, txt_data_nasc.Text, txt_end.Text, txt_usuario.Text, txt_senha.Text);
                DAO usuario = new DAO();


                usuario.Atualizar(func);

                MessageBox.Show("edição Efetuada com Sucesso");
                AtualizarListView();
                LimparCampos();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ltv_dados_DoubleClick(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = ltv_dados.FocusedItem.Index; //se clicou, setará como 0
                Id = int.Parse(ltv_dados.Items[index].SubItems[0].Text);
                txt_id.Text = ltv_dados.Items[index].SubItems[0].Text;
                txt_nome.Text = ltv_dados.Items[index].SubItems[1].Text;
                txt_cpf.Text = ltv_dados.Items[index].SubItems[2].Text;
                txt_email.Text = ltv_dados.Items[index].SubItems[3].Text;
                txt_data_nasc.Text = ltv_dados.Items[index].SubItems[4].Text;
                txt_end.Text = ltv_dados.Items[index].SubItems[5].Text;
                txt_telefone.Text = ltv_dados.Items[index].SubItems[6].Text;
                txt_usuario.Text = ltv_dados.Items[index].SubItems[7].Text;
                txt_senha.Text = ltv_dados.Items[index].SubItems[8].Text;






            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }
    }
}

