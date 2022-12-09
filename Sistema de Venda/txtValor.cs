using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sistema_de_Venda
{
    public class txtValor :  TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.White;
            this.SelectAll();

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;

            if (this.Text == "")
                return;
            
            try
            {
                double valor = Convert.ToDouble(this.Text.Replace("R$ ", ""));
                this.Text = String.Format("{0:c}", valor);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Valor invalido!!");
            }




        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.KeyCode == Keys.Escape) 
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
