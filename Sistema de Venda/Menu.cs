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
        public Menu(bool admin)
        {
           
            InitializeComponent();
            if(admin == false)
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

    }
}
