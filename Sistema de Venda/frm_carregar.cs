using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venda
{
    public partial class frm_carregar : Form
    {
        public frm_carregar()
        {
            InitializeComponent();
        }

        private void frm_carregar_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value >= 30) 
            {
                this.timer1.Enabled = false;
            }
            if(this.progressBar1.Value == 30)
            {
                this.Visible = false;
                frm_login login = new frm_login();
                login.ShowDialog();
            }
            else
                this.progressBar1.Value += 1;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
