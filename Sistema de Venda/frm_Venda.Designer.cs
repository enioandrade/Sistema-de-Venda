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
            this.btn_produtos = new System.Windows.Forms.Button();
            this.gbxItens = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_valor_uni = new Sistema_de_Venda.txtValor();
            this.ltv_venda = new System.Windows.Forms.ListView();
            this.clh_id_prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_quant_prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_valor_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_data_pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = new System.Windows.Forms.DateTimePicker();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_itens = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.panel_produtos = new System.Windows.Forms.Panel();
            this.ltv_panel = new System.Windows.Forms.ListView();
            this.clh_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_sabor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_disponivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_prod = new System.Windows.Forms.TextBox();
            this.panel_final = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ltv_fechamento = new System.Windows.Forms.ListView();
            this.clh_id_final = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_quant_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_total_pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clh_data_final = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_IdPedido = new System.Windows.Forms.TextBox();
            this.clh_pagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clh_imagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.gbxItens.SuspendLayout();
            this.panel_produtos.SuspendLayout();
            this.panel_final.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDA";
            // 
            // btn_produtos
            // 
            this.btn_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Location = new System.Drawing.Point(251, 55);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(60, 26);
            this.btn_produtos.TabIndex = 3;
            this.btn_produtos.Text = "...";
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // gbxItens
            // 
            this.gbxItens.Controls.Add(this.button4);
            this.gbxItens.Controls.Add(this.panel_produtos);
            this.gbxItens.Controls.Add(this.pictureBox1);
            this.gbxItens.Controls.Add(this.button1);
            this.gbxItens.Controls.Add(this.txt_valor_uni);
            this.gbxItens.Controls.Add(this.ltv_venda);
            this.gbxItens.Controls.Add(this.data);
            this.gbxItens.Controls.Add(this.btn_excluir);
            this.gbxItens.Controls.Add(this.btn_editar);
            this.gbxItens.Controls.Add(this.label5);
            this.gbxItens.Controls.Add(this.txt_itens);
            this.gbxItens.Controls.Add(this.btn_inserir);
            this.gbxItens.Controls.Add(this.label4);
            this.gbxItens.Controls.Add(this.label3);
            this.gbxItens.Controls.Add(this.txt_quant);
            this.gbxItens.Controls.Add(this.Produtos);
            this.gbxItens.Controls.Add(this.txt_produto);
            this.gbxItens.Controls.Add(this.btn_produtos);
            this.gbxItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItens.Location = new System.Drawing.Point(12, 70);
            this.gbxItens.Name = "gbxItens";
            this.gbxItens.Size = new System.Drawing.Size(823, 421);
            this.gbxItens.TabIndex = 4;
            this.gbxItens.TabStop = false;
            this.gbxItens.Text = "Itens";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(183, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 82);
            this.button1.TabIndex = 19;
            this.button1.Text = "Finalizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_valor_uni
            // 
            this.txt_valor_uni.BackColor = System.Drawing.SystemColors.Window;
            this.txt_valor_uni.Location = new System.Drawing.Point(400, 22);
            this.txt_valor_uni.Multiline = true;
            this.txt_valor_uni.Name = "txt_valor_uni";
            this.txt_valor_uni.ReadOnly = true;
            this.txt_valor_uni.Size = new System.Drawing.Size(87, 27);
            this.txt_valor_uni.TabIndex = 18;
            this.txt_valor_uni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ltv_venda
            // 
            this.ltv_venda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_id_prod,
            this.clh_quant_prod,
            this.clh_valor_total,
            this.clh_data_pedido});
            this.ltv_venda.FullRowSelect = true;
            this.ltv_venda.HideSelection = false;
            this.ltv_venda.Location = new System.Drawing.Point(6, 120);
            this.ltv_venda.Name = "ltv_venda";
            this.ltv_venda.Size = new System.Drawing.Size(482, 198);
            this.ltv_venda.TabIndex = 17;
            this.ltv_venda.UseCompatibleStateImageBehavior = false;
            this.ltv_venda.View = System.Windows.Forms.View.Details;
            this.ltv_venda.SelectedIndexChanged += new System.EventHandler(this.ltv_venda_SelectedIndexChanged);
            this.ltv_venda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltv_venda_MouseDoubleClick);
            // 
            // clh_id_prod
            // 
            this.clh_id_prod.Text = "ID";
            // 
            // clh_quant_prod
            // 
            this.clh_quant_prod.Text = "Quant";
            this.clh_quant_prod.Width = 107;
            // 
            // clh_valor_total
            // 
            this.clh_valor_total.Text = "Total";
            this.clh_valor_total.Width = 143;
            // 
            // clh_data_pedido
            // 
            this.clh_data_pedido.Text = "Data";
            this.clh_data_pedido.Width = 164;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(6, 87);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(370, 27);
            this.data.TabIndex = 16;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_excluir.Location = new System.Drawing.Point(402, 328);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(86, 82);
            this.btn_excluir.TabIndex = 15;
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
            this.btn_editar.Location = new System.Drawing.Point(294, 328);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 82);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Itens:";
            // 
            // txt_itens
            // 
            this.txt_itens.Location = new System.Drawing.Point(62, 332);
            this.txt_itens.Multiline = true;
            this.txt_itens.Name = "txt_itens";
            this.txt_itens.Size = new System.Drawing.Size(70, 23);
            this.txt_itens.TabIndex = 10;
            this.txt_itens.TextChanged += new System.EventHandler(this.txt_itens_TextChanged);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.Location = new System.Drawing.Point(400, 90);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(87, 26);
            this.btn_inserir.TabIndex = 9;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Uni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quant:";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(400, 58);
            this.txt_quant.Multiline = true;
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(87, 26);
            this.txt_quant.TabIndex = 5;
            this.txt_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txt_produto.Size = new System.Drawing.Size(239, 26);
            this.txt_produto.TabIndex = 2;
            this.txt_produto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_produtos
            // 
            this.panel_produtos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_produtos.Controls.Add(this.ltv_panel);
            this.panel_produtos.Controls.Add(this.label2);
            this.panel_produtos.Location = new System.Drawing.Point(105, 26);
            this.panel_produtos.Name = "panel_produtos";
            this.panel_produtos.Size = new System.Drawing.Size(588, 351);
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
            this.clh_disponivel,
            this.clh_imagem});
            this.ltv_panel.FullRowSelect = true;
            this.ltv_panel.HideSelection = false;
            this.ltv_panel.Location = new System.Drawing.Point(16, 65);
            this.ltv_panel.MultiSelect = false;
            this.ltv_panel.Name = "ltv_panel";
            this.ltv_panel.Size = new System.Drawing.Size(554, 241);
            this.ltv_panel.TabIndex = 11;
            this.ltv_panel.UseCompatibleStateImageBehavior = false;
            this.ltv_panel.View = System.Windows.Forms.View.Details;
            this.ltv_panel.SelectedIndexChanged += new System.EventHandler(this.ltv_panel_SelectedIndexChanged);
            this.ltv_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltv_panel_MouseDoubleClick);
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
            this.label2.Location = new System.Drawing.Point(124, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "PRODUTOS CADASTRADOS";
            // 
            // txt_id_prod
            // 
            this.txt_id_prod.Location = new System.Drawing.Point(22, 24);
            this.txt_id_prod.Multiline = true;
            this.txt_id_prod.Name = "txt_id_prod";
            this.txt_id_prod.ReadOnly = true;
            this.txt_id_prod.Size = new System.Drawing.Size(67, 26);
            this.txt_id_prod.TabIndex = 16;
            this.txt_id_prod.Visible = false;
            // 
            // panel_final
            // 
            this.panel_final.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_final.Controls.Add(this.txt_IdPedido);
            this.panel_final.Controls.Add(this.button3);
            this.panel_final.Controls.Add(this.button2);
            this.panel_final.Controls.Add(this.btn_voltar);
            this.panel_final.Controls.Add(this.ltv_fechamento);
            this.panel_final.Controls.Add(this.label10);
            this.panel_final.Controls.Add(this.label11);
            this.panel_final.Controls.Add(this.txt_valor);
            this.panel_final.Controls.Add(this.label9);
            this.panel_final.Controls.Add(this.txt_pago);
            this.panel_final.Controls.Add(this.txt_troco);
            this.panel_final.Controls.Add(this.groupBox1);
            this.panel_final.Controls.Add(this.label7);
            this.panel_final.Location = new System.Drawing.Point(289, 43);
            this.panel_final.Name = "panel_final";
            this.panel_final.Size = new System.Drawing.Size(537, 471);
            this.panel_final.TabIndex = 17;
            this.panel_final.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(17, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo Pagamento";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(415, 350);
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(100, 32);
            this.txt_valor.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Troco :";
            // 
            // txt_pago
            // 
            this.txt_pago.Location = new System.Drawing.Point(415, 388);
            this.txt_pago.Multiline = true;
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.Size = new System.Drawing.Size(100, 34);
            this.txt_pago.TabIndex = 18;
            this.txt_pago.TextChanged += new System.EventHandler(this.txt_pago_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(301, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Pago :";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 146);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cartão";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txt_troco
            // 
            this.txt_troco.Location = new System.Drawing.Point(415, 428);
            this.txt_troco.Multiline = true;
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.ReadOnly = true;
            this.txt_troco.Size = new System.Drawing.Size(100, 30);
            this.txt_troco.TabIndex = 17;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pix";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dinheiro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Venda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(145, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fechamento da Venda";
            // 
            // ltv_fechamento
            // 
            this.ltv_fechamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_id_final,
            this.clh_quant_total,
            this.clh_total_pedido,
            this.Clh_data_final,
            this.clh_pagamento});
            this.ltv_fechamento.HideSelection = false;
            this.ltv_fechamento.Location = new System.Drawing.Point(179, 124);
            this.ltv_fechamento.Name = "ltv_fechamento";
            this.ltv_fechamento.Size = new System.Drawing.Size(347, 208);
            this.ltv_fechamento.TabIndex = 19;
            this.ltv_fechamento.UseCompatibleStateImageBehavior = false;
            this.ltv_fechamento.View = System.Windows.Forms.View.Details;
            // 
            // clh_id_final
            // 
            this.clh_id_final.Text = "ID";
            // 
            // clh_quant_total
            // 
            this.clh_quant_total.Text = "Quant";
            this.clh_quant_total.Width = 74;
            // 
            // clh_total_pedido
            // 
            this.clh_total_pedido.Text = "Total";
            this.clh_total_pedido.Width = 77;
            // 
            // Clh_data_final
            // 
            this.Clh_data_final.Text = "Data Final";
            this.Clh_data_final.Width = 94;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(440, 13);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(86, 82);
            this.btn_voltar.TabIndex = 20;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(17, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 82);
            this.button2.TabIndex = 20;
            this.button2.Text = "Gerar PDF";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(126, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 83);
            this.button3.TabIndex = 20;
            this.button3.Text = "Inserir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_IdPedido
            // 
            this.txt_IdPedido.Location = new System.Drawing.Point(17, 86);
            this.txt_IdPedido.Multiline = true;
            this.txt_IdPedido.Name = "txt_IdPedido";
            this.txt_IdPedido.Size = new System.Drawing.Size(43, 22);
            this.txt_IdPedido.TabIndex = 21;
            this.txt_IdPedido.Visible = false;
            // 
            // clh_pagamento
            // 
            this.clh_pagamento.Text = "Metodo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(545, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clh_imagem
            // 
            this.clh_imagem.Text = "imagem";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(728, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 82);
            this.button4.TabIndex = 22;
            this.button4.Text = "Voltar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 539);
            this.Controls.Add(this.panel_final);
            this.Controls.Add(this.txt_id_prod);
            this.Controls.Add(this.gbxItens);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Venda";
            this.Load += new System.EventHandler(this.frm_Venda_Load_1);
            this.gbxItens.ResumeLayout(false);
            this.gbxItens.PerformLayout();
            this.panel_produtos.ResumeLayout(false);
            this.panel_produtos.PerformLayout();
            this.panel_final.ResumeLayout(false);
            this.panel_final.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.GroupBox gbxItens;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label Produtos;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_itens;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_id_prod;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.ListView ltv_venda;
        private System.Windows.Forms.ColumnHeader clh_id_prod;
        private System.Windows.Forms.ColumnHeader clh_quant_prod;
        private System.Windows.Forms.ColumnHeader clh_valor_total;
        private System.Windows.Forms.ColumnHeader clh_data_pedido;
        private System.Windows.Forms.Panel panel_produtos;
        private System.Windows.Forms.ListView ltv_panel;
        private System.Windows.Forms.ColumnHeader clh_id;
        private System.Windows.Forms.ColumnHeader clh_nome;
        private System.Windows.Forms.ColumnHeader clh_valor;
        private System.Windows.Forms.ColumnHeader clh_quant;
        private System.Windows.Forms.ColumnHeader clh_sabor;
        private System.Windows.Forms.ColumnHeader clh_tipo;
        private System.Windows.Forms.ColumnHeader clh_disponivel;
        private System.Windows.Forms.Label label2;
        private txtValor txt_valor_uni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_final;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView ltv_fechamento;
        private System.Windows.Forms.ColumnHeader clh_id_final;
        private System.Windows.Forms.ColumnHeader clh_quant_total;
        private System.Windows.Forms.ColumnHeader clh_total_pedido;
        private System.Windows.Forms.ColumnHeader Clh_data_final;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_IdPedido;
        private System.Windows.Forms.ColumnHeader clh_pagamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader clh_imagem;
        private System.Windows.Forms.Button button4;
    }
}