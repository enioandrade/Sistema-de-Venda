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
    public partial class Menu : Form
    {
        public Menu(string admin)
        {
           
            InitializeComponent();
            if(admin == "NAO")
                cadastrosToolStripMenuItem.Visible = false;
        }



        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            frm_funcionarios frm = new frm_funcionarios();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OBRIGADO POR UTILIZAR O SISTEMA!");
            Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_produto frm = new frm_produto();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_Venda frm = new frm_Venda();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
