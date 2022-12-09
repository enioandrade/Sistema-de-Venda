using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venda
{
    public partial class frm_Venda : Form
    {
        public frm_Venda()
        {
            InitializeComponent();
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            panel_produtos.Visible = true;
        }
        private void btn_voltar_Click_1(object sender, EventArgs e)
        {
            panel_produtos.Visible = false;
        }



  
        private void AtualizarListView()
        {
            ltv_panel.Items.Clear();
            DAO Dao = new DAO();

            List<Produtos> produtos = Dao.ListarTodosProdutos();
            if (produtos.Count > 0)
            {
                foreach (var proj in produtos)
                {
                    ListViewItem lv = new ListViewItem(proj.Id.ToString());
                    lv.SubItems.Add(proj.Produto);
                    lv.SubItems.Add(proj.Valor);
                    lv.SubItems.Add(proj.Quantidade);
                    lv.SubItems.Add(proj.Sabor);
                    lv.SubItems.Add(proj.Tipo);
                    lv.SubItems.Add(proj.Disponivel);
                    ltv_panel.Items.Add(lv);

                }
            }
        }
        private void frm_Venda_Load_1(object sender, EventArgs e)
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
    }
}
