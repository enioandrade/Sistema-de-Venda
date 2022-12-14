using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Venda
{
    public partial class frm_produto : Form
    {
        private int Id;

        public frm_produto()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos proj;




                
                if (txt_disp.Checked)
                {
                    proj = new Produtos(txt_produto.Text, Convert.ToDecimal(txt_valor.Text), int.Parse(txt_quant.Text), txt_sabor.Text, txt_tipo.Text,txt_imagem.Text, "DISPONIVEL");
                    DAO Dao = new DAO();
                    Dao.InserirProduto(proj);
                }
                else if (txt_disp.Checked == false)
                {
                    proj = new Produtos(txt_produto.Text, Convert.ToDecimal(txt_valor.Text), int.Parse(txt_quant.Text), txt_sabor.Text, txt_tipo.Text, txt_imagem.Text, " NAO DISPONIVEL");
                    DAO Dao = new DAO();
                    Dao.InserirProduto(proj);
                }
               
                MessageBox.Show("Cadastro Efetuado com Sucesso");
                AtualizarListView();
                LimparCampos();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void AtualizarListView()
        {
            ltv_produto.Items.Clear();
            DAO Dao = new DAO();

            List<Produtos> produtos = Dao.ListarTodosProdutos();
            if (produtos.Count > 0)
            {
                foreach (var proj in produtos)
                {
                    ListViewItem lv = new ListViewItem(proj.Id.ToString());
                    lv.SubItems.Add(proj.Produto);
                    lv.SubItems.Add(proj.Valor.ToString());
                    lv.SubItems.Add(proj.Quantidade.ToString());
                    lv.SubItems.Add(proj.Sabor);
                    lv.SubItems.Add(proj.Tipo);
                    lv.SubItems.Add(proj.Disponivel);
                    lv.SubItems.Add(proj.Imagem);
                    ltv_produto.Items.Add(lv);

                }
            }
        }

        private void LimparCampos()
        {
            txt_produto.Clear();
            txt_valor.Clear();
            txt_quant.Clear();
            txt_sabor.Clear();
            txt_tipo.Clear();
            txt_id.Clear();
            txt_imagem.Clear();
            txt_disp.Checked= false;
            pictureBox1.Image = null;
            


        }

        private void frm_produto_Load(object sender, EventArgs e)
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
                    DAO produto = new DAO();
                    produto.ExcluirProduto(Id);
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

        private void ltv_produto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltv_produto.FocusedItem.Index; //se clicou, setará como 0
                Id = int.Parse(ltv_produto.Items[index].SubItems[0].Text);
                txt_id.Text = ltv_produto.Items[index].SubItems[0].Text;
                txt_produto.Text = ltv_produto.Items[index].SubItems[1].Text;
                txt_valor.Text = ltv_produto.Items[index].SubItems[2].Text;
                txt_quant.Text = ltv_produto.Items[index].SubItems[3].Text;
                txt_sabor.Text = ltv_produto.Items[index].SubItems[4].Text;
                txt_tipo.Text = ltv_produto.Items[index].SubItems[5].Text;
                if (ltv_produto.Items[index].SubItems[6].Text == "DISPONIVEL")
                {
                    txt_disp.Checked = true;
                }
                else if (ltv_produto.Items[index].SubItems[6].Text == "NAO DISPONIVEL")
                {
                    txt_disp.Checked = false;
                }
                pictureBox1.ImageLocation = ltv_produto.Items[index].SubItems[7].Text;
                txt_imagem.Text = ltv_produto.Items[index].SubItems[7].Text;


            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {

                Produtos proj;

                if (txt_disp.Checked)
                {
                    proj = new Produtos(Id,txt_produto.Text, Convert.ToDecimal(txt_valor.Text), int.Parse(txt_quant.Text), txt_sabor.Text, txt_tipo.Text, txt_imagem.Text, "DISPONIVEL");
                    DAO Dao = new DAO();
                    Dao.AtualizarProduto(proj);
                }
                else if (txt_disp.Checked == false)
                {
                    proj = new Produtos(Id,txt_produto.Text, Convert.ToDecimal(txt_valor.Text), int.Parse(txt_quant.Text), txt_sabor.Text, txt_tipo.Text, txt_imagem.Text, " NAO DISPONIVEL");
                    DAO Dao = new DAO();
                    Dao.AtualizarProduto(proj);
                }


                MessageBox.Show("edição Efetuada com Sucesso");
                AtualizarListView();
                LimparCampos();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_imagem_Click(object sender, EventArgs e)
        {

            
                OpenFileDialog g = new OpenFileDialog();
                g.Filter = "Imagens(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png";
                if (g.ShowDialog() == DialogResult.OK)
                {
                pictureBox1.Image = new Bitmap(g.FileName);

                txt_imagem.Text =g.FileName;
               
                }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

