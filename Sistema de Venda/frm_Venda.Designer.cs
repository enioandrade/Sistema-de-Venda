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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_produtos = new System.Windows.Forms.Panel();
            this.ltv_panel = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.clh_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_sabor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_disponivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // panel_produtos
            // 
            this.panel_produtos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_produtos.Controls.Add(this.ltv_panel);
            this.panel_produtos.Controls.Add(this.label2);
            this.panel_produtos.Controls.Add(this.btn_voltar);
            this.panel_produtos.Location = new System.Drawing.Point(131, 12);
            this.panel_produtos.Name = "panel_produtos";
            this.panel_produtos.Size = new System.Drawing.Size(652, 424);
            this.panel_produtos.TabIndex = 2;
            this.panel_produtos.Visible = false;
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
            this.ltv_panel.HideSelection = false;
            this.ltv_panel.Location = new System.Drawing.Point(3, 299);
            this.ltv_panel.Name = "ltv_panel";
            this.ltv_panel.Size = new System.Drawing.Size(646, 122);
            this.ltv_panel.TabIndex = 11;
            this.ltv_panel.UseCompatibleStateImageBehavior = false;
            this.ltv_panel.View = System.Windows.Forms.View.Details;
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
            this.btn_voltar.Location = new System.Drawing.Point(532, 12);
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
            this.btn_produtos.Location = new System.Drawing.Point(731, 321);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(103, 69);
            this.btn_produtos.TabIndex = 3;
            this.btn_produtos.Text = "Produtos Cadastrados";
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
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
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 503);
            this.Controls.Add(this.panel_produtos);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Venda";
            this.Text = "frm_Venda";
            this.Load += new System.EventHandler(this.frm_Venda_Load_1);
            this.panel_produtos.ResumeLayout(false);
            this.panel_produtos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}