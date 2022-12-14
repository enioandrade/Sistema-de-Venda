using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Sistema_de_Venda
{
    public partial class frm_Venda : Form
    {
        
        public frm_Venda()
        {
            InitializeComponent();
        }
        private int Id;

        private void ValorTotal()
        {
            var total = 0m;
            for (int i = 0; i < ltv_venda.Items.Count; i++)

            {
                total += decimal.Parse(ltv_venda.Items[i].SubItems[2].Text); ;
            }
            txt_valor.Text = total.ToString("N");

        }

        private void Itens()
        {
            var total = 0m;
            for (int i = 0; i < ltv_venda.Items.Count; i++)

            {
                total += decimal.Parse(ltv_venda.Items[i].SubItems[1].Text); ;
            }
            txt_itens.Text = total.ToString("N");

        }

        private void Troco()
        {
            if (txt_pago.Text == string.Empty)
            {
                MessageBox.Show("Não existe entrada de caixa ");
                txt_troco.Clear();
                return;
            }

            else
            {
                decimal total = 0m;
                decimal pago = decimal.Parse(txt_valor.Text);

                decimal pagar = decimal.Parse(txt_pago.Text);

                total += (pagar - pago);

                txt_troco.Text = total.ToString("N");
            }
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            panel_produtos.Visible = true;
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
                    lv.SubItems.Add(proj.Valor.ToString());
                    lv.SubItems.Add(proj.Quantidade.ToString());
                    lv.SubItems.Add(proj.Sabor);
                    lv.SubItems.Add(proj.Tipo);
                    lv.SubItems.Add(proj.Disponivel);
                    lv.SubItems.Add(proj.Imagem);
                    ltv_panel.Items.Add(lv);

                }
            }
        }
        private void frm_Venda_Load_1(object sender, EventArgs e)
        {

            try
            {
                AtualizarListViewVendas();
                AtualizarListView();
                AtualizarListViewFechamento();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void ltv_panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltv_panel.FocusedItem.Index; //se clicou, setará como 0
                Id = int.Parse(ltv_panel.Items[index].SubItems[0].Text);
                txt_id_prod.Text = ltv_panel.Items[index].SubItems[0].Text;
                txt_produto.Text = ltv_panel.Items[index].SubItems[1].Text;
                txt_valor_uni.Text = ltv_panel.Items[index].SubItems[2].Text;
                pictureBox1.ImageLocation = ltv_panel.Items[index].SubItems[7].Text;

            }

            catch (Exception)

            {

                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
            panel_produtos.Visible = false;
        }

        private void AtualizarListViewVendas()
        {
            ltv_venda.Items.Clear();
            DAO Dao = new DAO();

            List<venda> produtos = Dao.ListarTodasVendas();
            if (produtos.Count > 0)
            {
                foreach (var proj in produtos)
                {
                    ListViewItem lv = new ListViewItem(proj.Id.ToString());
                    lv.SubItems.Add(proj.Quantidade.ToString());
                    lv.SubItems.Add(proj.ValorTotal.ToString());
                    lv.SubItems.Add(proj.Data.ToString());
                    ltv_venda.Items.Add(lv);

                }
            }
        }

        private void AtualizarListViewFechamento()
        {
            ltv_fechamento.Items.Clear();
            DAO Dao = new DAO();

            List<Fechamento> produtos = Dao.ListarFechamento();
            if (produtos.Count > 0)
            {
                foreach (var proj in produtos)
                {
                    ListViewItem lv = new ListViewItem(proj.Id.ToString());
                    lv.SubItems.Add(proj.Itens.ToString());
                    lv.SubItems.Add(proj.ValorTotal.ToString());
                    lv.SubItems.Add(proj.Data.ToString());
                    lv.SubItems.Add(proj.Pagamento);
                    ltv_fechamento.Items.Add(lv);

                }
            }
        }

        private void ltv_panel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                venda proj;
     
                    proj = new venda 
                    ( int.Parse(txt_quant.Text), Convert.ToDecimal(txt_valor_uni.Text), DateTime.Parse(data.Text), int.Parse(txt_id_prod.Text));
                    DAO Dao = new DAO();
                    Dao.InserirVendas(proj);
       

                MessageBox.Show("Cadastro Efetuado com Sucesso");
                AtualizarListViewVendas();
                

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ltv_venda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltv_venda.FocusedItem.Index; //se clicou, setará como 0
                Id = int.Parse(ltv_venda.Items[index].SubItems[0].Text);
                txt_IdPedido.Text = ltv_venda.Items[index].SubItems[0].Text;
                txt_quant.Text = ltv_venda.Items[index].SubItems[1].Text;
                txt_valor.Text = ltv_venda.Items[index].SubItems[2].Text;
                data.Text = ltv_venda.Items[index].SubItems[3].Text;
                ValorTotal();
                Itens();

            }

            catch (Exception)

            {

                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
            
        }

        private void txt_itens_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {

               venda func;



                func = new venda
                    (Id,int.Parse(txt_quant.Text), Convert.ToDecimal(txt_valor_uni.Text), DateTime.Parse(data.Text), int.Parse(txt_id_prod.Text));
                DAO Dao = new DAO();
                Dao.AtualizarVenda(func);


                MessageBox.Show("edição Efetuada com Sucesso");
                AtualizarListViewVendas();
             

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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
                    produto.ExcluirVenda(Id);
                    MessageBox.Show("Funcionario excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "ERRO AO EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AtualizarListViewVendas();
        }

        private void txt_pago_TextChanged(object sender, EventArgs e)
        {
            Troco();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel_final.Visible = true;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            panel_final.Visible= false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string nomeArquivo = @"D:\source\repos\Sistema de Venda\Relatorio\Pedidos.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\source\repos\Sistema de Venda\icones\logo.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;


            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("SORVETERIA\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("RELATÓRIO DE VENDA\n\n");

            PdfPTable tabela1 = new PdfPTable(5);
            tabela1.DefaultCell.FixedHeight = 20;

            PdfPCell celula1 = new PdfPCell(new Phrase("TABELA DE PEDIDOS"));
            celula1.Colspan = 5;

            tabela1.AddCell(celula1);

            celula1.FixedHeight = 40;
            celula1.HorizontalAlignment = Element.ALIGN_CENTER;
            celula1.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela1.AddCell(celula1);



            tabela1.AddCell("Id");
            tabela1.AddCell("Quantidade");
            tabela1.AddCell("Total");
            tabela1.AddCell("Data");
            tabela1.AddCell("Metodo");




            for (int i = 0; i < ltv_fechamento.Items.Count; i++)
            {
                tabela1.AddCell(ltv_fechamento.Items[i].SubItems[0].Text);
                tabela1.AddCell(ltv_fechamento.Items[i].SubItems[1].Text);
                tabela1.AddCell(ltv_fechamento.Items[i].SubItems[2].Text);
                tabela1.AddCell(ltv_fechamento.Items[i].SubItems[3].Text);
                tabela1.AddCell(ltv_fechamento.Items[i].SubItems[4].Text);


            }


            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(tabela1);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult resultado = MessageBox.Show("Deseja abrir o relatório de pedidos?", "Relatório", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"D:\source\repos\Sistema de Venda\Relatorio\Pedidos.pdf");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Fechamento proj;
                if (radioButton1.Checked)
                {
                    proj = new Fechamento

                   (int.Parse(txt_quant.Text), Convert.ToDecimal(txt_valor.Text), "DINHEIRO", int.Parse(txt_IdPedido.Text));
                    DAO Dao = new DAO();
                    Dao.InserirFechamento(proj);

                }
                if (radioButton2.Checked)
                {
                    proj = new Fechamento

                   (int.Parse(txt_quant.Text), Convert.ToDecimal(txt_valor.Text), "PIX", int.Parse(txt_IdPedido.Text));
                    DAO Dao = new DAO();
                    Dao.InserirFechamento(proj);

                }
                if (radioButton3.Checked)
                {
                    proj = new Fechamento

                   (int.Parse(txt_quant.Text), Convert.ToDecimal(txt_valor.Text), "CARTAO", int.Parse(txt_IdPedido.Text));
                    DAO Dao = new DAO();
                    Dao.InserirFechamento(proj);

                }



                MessageBox.Show("Cadastro Efetuado com Sucesso");
                AtualizarListViewFechamento();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ltv_venda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
