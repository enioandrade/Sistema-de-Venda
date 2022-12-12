namespace Sistema_de_Venda
{
    partial class frm_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_produto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sabor = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_disp = new System.Windows.Forms.CheckBox();
            this.ltv_produto = new System.Windows.Forms.ListView();
            this.clh_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_sabor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_disp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_valor = new Sistema_de_Venda.txtValor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "CADASTRO DE PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto :";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(193, 130);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(533, 22);
            this.txt_produto.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor unitario :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade :";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(143, 230);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(112, 22);
            this.txt_quant.TabIndex = 2;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 304);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(86, 82);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Salvar";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_excluir.Location = new System.Drawing.Point(113, 304);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(86, 82);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(546, 304);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 82);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(652, 304);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(86, 82);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(51, 90);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(57, 22);
            this.txt_id.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sabor :";
            // 
            // txt_sabor
            // 
            this.txt_sabor.Location = new System.Drawing.Point(360, 176);
            this.txt_sabor.Name = "txt_sabor";
            this.txt_sabor.Size = new System.Drawing.Size(183, 22);
            this.txt_sabor.TabIndex = 29;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(360, 234);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(183, 22);
            this.txt_tipo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tipo :";
            // 
            // txt_disp
            // 
            this.txt_disp.AutoSize = true;
            this.txt_disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_disp.Location = new System.Drawing.Point(573, 177);
            this.txt_disp.Name = "txt_disp";
            this.txt_disp.Size = new System.Drawing.Size(153, 24);
            this.txt_disp.TabIndex = 32;
            this.txt_disp.Text = "Esta disponivel?";
            this.txt_disp.UseVisualStyleBackColor = true;
            // 
            // ltv_produto
            // 
            this.ltv_produto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_id,
            this.clh_produto,
            this.clh_valor,
            this.clh_quant,
            this.clh_sabor,
            this.clh_tipo,
            this.clh_disp});
            this.ltv_produto.FullRowSelect = true;
            this.ltv_produto.HideSelection = false;
            this.ltv_produto.Location = new System.Drawing.Point(12, 392);
            this.ltv_produto.Name = "ltv_produto";
            this.ltv_produto.Size = new System.Drawing.Size(726, 132);
            this.ltv_produto.TabIndex = 33;
            this.ltv_produto.UseCompatibleStateImageBehavior = false;
            this.ltv_produto.View = System.Windows.Forms.View.Details;
            this.ltv_produto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltv_produto_MouseDoubleClick);
            // 
            // clh_id
            // 
            this.clh_id.Text = "ID";
            // 
            // clh_produto
            // 
            this.clh_produto.Text = "Nome";
            // 
            // clh_valor
            // 
            this.clh_valor.Text = "Valor";
            this.clh_valor.Width = 121;
            // 
            // clh_quant
            // 
            this.clh_quant.Text = "Quantidade";
            this.clh_quant.Width = 119;
            // 
            // clh_sabor
            // 
            this.clh_sabor.Text = "Sabor";
            this.clh_sabor.Width = 131;
            // 
            // clh_tipo
            // 
            this.clh_tipo.Text = "Tipo";
            this.clh_tipo.Width = 125;
            // 
            // clh_disp
            // 
            this.clh_disp.Text = "Disponivel";
            this.clh_disp.Width = 363;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(155, 179);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 22);
            this.txt_valor.TabIndex = 1;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(751, 566);
            this.Controls.Add(this.ltv_produto);
            this.Controls.Add(this.txt_disp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_sabor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_produto";
            this.Load += new System.EventHandler(this.frm_produto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label3;
        private txtValor txt_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sabor;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox txt_disp;
        private System.Windows.Forms.ListView ltv_produto;
        private System.Windows.Forms.ColumnHeader clh_id;
        private System.Windows.Forms.ColumnHeader clh_produto;
        private System.Windows.Forms.ColumnHeader clh_valor;
        private System.Windows.Forms.ColumnHeader clh_quant;
        private System.Windows.Forms.ColumnHeader clh_sabor;
        private System.Windows.Forms.ColumnHeader clh_tipo;
        private System.Windows.Forms.ColumnHeader clh_disp;
    }
}