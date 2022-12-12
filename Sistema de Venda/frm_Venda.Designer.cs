namespace Sistema_de_Venda
{
    partial class frm_Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Venda));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_produtos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ltv_panel = new System.Windows.Forms.ListView();
            this.clh_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_sabor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_disponivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.gbxItens = new System.Windows.Forms.GroupBox();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_itens = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor_uni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.panel_produtos.SuspendLayout();
            this.gbxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDA";
            // 
            // panel_produtos
            // 
            this.panel_produtos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_produtos.Controls.Add(this.button1);
            this.panel_produtos.Controls.Add(this.ltv_panel);
            this.panel_produtos.Controls.Add(this.label2);
            this.panel_produtos.Controls.Add(this.btn_voltar);
            this.panel_produtos.Location = new System.Drawing.Point(0, 87);
            this.panel_produtos.Name = "panel_produtos";
            this.panel_produtos.Size = new System.Drawing.Size(575, 389);
            this.panel_produtos.TabIndex = 2;
            this.panel_produtos.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ltv_panel
            // 
            this.ltv_panel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_id,
            this.clh_nome,
            this.clh_valor,
            this.clh_quant,
            this.clh_sabor,
            this.clh_tipo,
            this.clh_disponivel});
            this.ltv_panel.FullRowSelect = true;
            this.ltv_panel.HideSelection = false;
            this.ltv_panel.Location = new System.Drawing.Point(4, 113);
            this.ltv_panel.MultiSelect = false;
            this.ltv_panel.Name = "ltv_panel";
            this.ltv_panel.Size = new System.Drawing.Size(554, 262);
            this.ltv_panel.TabIndex = 11;
            this.ltv_panel.UseCompatibleStateImageBehavior = false;
            this.ltv_panel.View = System.Windows.Forms.View.Details;
            this.ltv_panel.SelectedIndexChanged += new System.EventHandler(this.ltv_panel_SelectedIndexChanged);
            // 
            // clh_id
            // 
            this.clh_id.Text = "ID";
            // 
            // clh_nome
            // 
            this.clh_nome.Text = "Nome";
            this.clh_nome.Width = 87;
            // 
            // clh_valor
            // 
            this.clh_valor.Text = "Valor";
            this.clh_valor.Width = 109;
            // 
            // clh_quant
            // 
            this.clh_quant.Text = "quant";
            this.clh_quant.Width = 122;
            // 
            // clh_sabor
            // 
            this.clh_sabor.Text = "Sabor";
            this.clh_sabor.Width = 81;
            // 
            // clh_tipo
            // 
            this.clh_tipo.Text = "Tipo";
            this.clh_tipo.Width = 78;
            // 
            // clh_disponivel
            // 
            this.clh_disponivel.Text = "Disponivel";
            this.clh_disponivel.Width = 263;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "PRODUTO CADASTRADOS";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(470, 25);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(86, 82);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click_1);
            // 
            // btn_produtos
            // 
            this.btn_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Location = new System.Drawing.Point(233, 55);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(60, 26);
            this.btn_produtos.TabIndex = 3;
            this.btn_produtos.Text = "...";
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // gbxItens
            // 
            this.gbxItens.Controls.Add(this.panel_produtos);
            this.gbxItens.Controls.Add(this.dgw);
            this.gbxItens.Controls.Add(this.btn_excluir);
            this.gbxItens.Controls.Add(this.btn_editar);
            this.gbxItens.Controls.Add(this.txt_valor);
            this.gbxItens.Controls.Add(this.label6);
            this.gbxItens.Controls.Add(this.label5);
            this.gbxItens.Controls.Add(this.txt_itens);
            this.gbxItens.Controls.Add(this.btn_inserir);
            this.gbxItens.Controls.Add(this.label4);
            this.gbxItens.Controls.Add(this.txt_valor_uni);
            this.gbxItens.Controls.Add(this.label3);
            this.gbxItens.Controls.Add(this.txt_quant);
            this.gbxItens.Controls.Add(this.Produtos);
            this.gbxItens.Controls.Add(this.txt_produto);
            this.gbxItens.Controls.Add(this.btn_produtos);
            this.gbxItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItens.Location = new System.Drawing.Point(16, 70);
            this.gbxItens.Name = "gbxItens";
            this.gbxItens.Size = new System.Drawing.Size(587, 475);
            this.gbxItens.TabIndex = 4;
            this.gbxItens.TabStop = false;
            this.gbxItens.Text = "Itens";
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(6, 87);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.Size = new System.Drawing.Size(558, 283);
            this.dgw.TabIndex = 0;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_excluir.Location = new System.Drawing.Point(476, 387);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(86, 82);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(383, 387);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 82);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(186, 381);
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(95, 23);
            this.txt_valor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Itens:";
            // 
            // txt_itens
            // 
            this.txt_itens.Location = new System.Drawing.Point(57, 381);
            this.txt_itens.Multiline = true;
            this.txt_itens.Name = "txt_itens";
            this.txt_itens.Size = new System.Drawing.Size(70, 23);
            this.txt_itens.TabIndex = 10;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.Location = new System.Drawing.Point(383, 55);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(87, 26);
            this.btn_inserir.TabIndex = 9;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Uni";
            // 
            // txt_valor_uni
            // 
            this.txt_valor_uni.Location = new System.Drawing.Point(476, 55);
            this.txt_valor_uni.Multiline = true;
            this.txt_valor_uni.Name = "txt_valor_uni";
            this.txt_valor_uni.ReadOnly = true;
            this.txt_valor_uni.Size = new System.Drawing.Size(88, 26);
            this.txt_valor_uni.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quant";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(309, 55);
            this.txt_quant.Multiline = true;
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(67, 26);
            this.txt_quant.TabIndex = 5;
            // 
            // Produtos
            // 
            this.Produtos.AutoSize = true;
            this.Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produtos.Location = new System.Drawing.Point(6, 32);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(67, 20);
            this.Produtos.TabIndex = 4;
            this.Produtos.Text = "Produto";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(6, 55);
            this.txt_produto.Multiline = true;
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(218, 26);
            this.txt_produto.TabIndex = 2;
            this.txt_produto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 557);
            this.Controls.Add(this.gbxItens);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Venda";
            this.Load += new System.EventHandler(this.frm_Venda_Load_1);
            this.panel_produtos.ResumeLayout(false);
            this.panel_produtos.PerformLayout();
            this.gbxItens.ResumeLayout(false);
            this.gbxItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_produtos;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.ListView ltv_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ColumnHeader clh_id;
        private System.Windows.Forms.ColumnHeader clh_nome;
        private System.Windows.Forms.ColumnHeader clh_valor;
        private System.Windows.Forms.ColumnHeader clh_quant;
        private System.Windows.Forms.ColumnHeader clh_sabor;
        private System.Windows.Forms.ColumnHeader clh_tipo;
        private System.Windows.Forms.ColumnHeader clh_disponivel;
        private System.Windows.Forms.GroupBox gbxItens;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor_uni;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_itens;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button1;
    }
}