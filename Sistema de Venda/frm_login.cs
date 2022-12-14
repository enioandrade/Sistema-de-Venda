using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venda
{
    public partial class frm_login : Form
    {
        SqlConnection sqlCon = null;
        string strCon = @"Data Source=" + Environment.MachineName +
                       @"\SQLEXPRESS;Initial Catalog=Vendas;Integrated Security=true";
        private string strSql = string.Empty;

        public frm_login()
        {
            InitializeComponent();
            txt_usuario.Select();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            string admin;
            try
            {
                Funcionario login;
                string usuario = txt_usuario.Text;
                string senha = txt_senha.Text;

                Criptografia Cry = new Criptografia();
                string cript = Cry.EncodeToBase64(senha);

                login = new Funcionario(txt_usuario.Text, cript);
                DAO Dao = new DAO();
                admin = Dao.EntrarLogin(login);

                
                //MessageBox.Show(cript);


                if (admin != null)
                {
                    if (admin.Equals("SIM"))
                    {
                        this.Visible = false;
                        Menu menu = new Menu(admin);
                        menu.ShowDialog();
                        this.Visible = true;
                    }
                        if (admin.Equals("NAO"))
                        {
                            this.Visible = false;
                            Menu menu = new Menu(admin);
                            menu.ShowDialog();
                            this.Visible = true;
                        }

                    }
                else
                {
                    MessageBox.Show("Dados não encontrados!\n" + "Tente novamente ou realize seu cadastro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PROBLEMAS AO FAZER LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_usuario.Clear();
            txt_senha.Clear();

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
