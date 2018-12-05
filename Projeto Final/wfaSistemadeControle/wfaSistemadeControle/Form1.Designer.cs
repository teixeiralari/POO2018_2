namespace wfaSistemadeControle
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProduto = new System.Windows.Forms.TabPage();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.cbMetrica = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQtdCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUnidadeCompra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCustoProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReceita = new System.Windows.Forms.TabPage();
            this.btnGravarReceita = new System.Windows.Forms.Button();
            this.dgReceitaFinal = new System.Windows.Forms.DataGridView();
            this.cod_cardapioReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_produtoReceita2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_utilizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirReceita = new System.Windows.Forms.Button();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.dgProdutosReceita = new System.Windows.Forms.DataGridView();
            this.cod_produtoReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produtoReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbItensCardapio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbVendas = new System.Windows.Forms.TabPage();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbVendasCardapio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtdVendida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInserirVenda = new System.Windows.Forms.Button();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cardVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cardVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            this.btnExcluirVendas = new System.Windows.Forms.Button();
            this.btnConsultarTodas = new System.Windows.Forms.Button();
            this.cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCardapio = new System.Windows.Forms.TabPage();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.imagemCardapio = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgCardapio = new System.Windows.Forms.DataGridView();
            this.btnadicionarCardapio = new System.Windows.Forms.Button();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cod_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tbReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceitaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutosReceita)).BeginInit();
            this.tbVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.tbCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCardapio);
            this.tabControl1.Controls.Add(this.tbProduto);
            this.tabControl1.Controls.Add(this.tbReceita);
            this.tabControl1.Controls.Add(this.tbVendas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbProduto
            // 
            this.tbProduto.BackColor = System.Drawing.Color.Transparent;
            this.tbProduto.BackgroundImage = global::wfaSistemadeControle.Properties.Resources._930543712_XG;
            this.tbProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbProduto.Controls.Add(this.btnExcluirProduto);
            this.tbProduto.Controls.Add(this.btnEditarProduto);
            this.tbProduto.Controls.Add(this.btnConsultarProduto);
            this.tbProduto.Controls.Add(this.dgProdutos);
            this.tbProduto.Controls.Add(this.btnAdicionarProduto);
            this.tbProduto.Controls.Add(this.cbMetrica);
            this.tbProduto.Controls.Add(this.label8);
            this.tbProduto.Controls.Add(this.txtQtdCompra);
            this.tbProduto.Controls.Add(this.label7);
            this.tbProduto.Controls.Add(this.cbUnidadeCompra);
            this.tbProduto.Controls.Add(this.label6);
            this.tbProduto.Controls.Add(this.txtProduto);
            this.tbProduto.Controls.Add(this.txtCustoProd);
            this.tbProduto.Controls.Add(this.label4);
            this.tbProduto.Controls.Add(this.label5);
            this.tbProduto.Location = new System.Drawing.Point(4, 22);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tbProduto.Size = new System.Drawing.Size(593, 335);
            this.tbProduto.TabIndex = 1;
            this.tbProduto.Text = "Produto";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.Location = new System.Drawing.Point(396, 301);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(99, 26);
            this.btnExcluirProduto.TabIndex = 18;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.Location = new System.Drawing.Point(242, 301);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(99, 26);
            this.btnEditarProduto.TabIndex = 17;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProduto.Location = new System.Drawing.Point(88, 301);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(99, 26);
            this.btnConsultarProduto.TabIndex = 16;
            this.btnConsultarProduto.Text = "Consultar";
            this.btnConsultarProduto.UseVisualStyleBackColor = true;
            this.btnConsultarProduto.Click += new System.EventHandler(this.btnConsultarProduto_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_produto,
            this.nome_produto,
            this.custo_unidade,
            this.unidade_compra,
            this.qtd_compra,
            this.metrica});
            this.dgProdutos.Location = new System.Drawing.Point(8, 152);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(576, 143);
            this.dgProdutos.TabIndex = 15;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(477, 60);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(107, 43);
            this.btnAdicionarProduto.TabIndex = 14;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // cbMetrica
            // 
            this.cbMetrica.FormattingEnabled = true;
            this.cbMetrica.Items.AddRange(new object[] {
            "Gramas",
            "Litros",
            "Unidade"});
            this.cbMetrica.Location = new System.Drawing.Point(350, 91);
            this.cbMetrica.Name = "cbMetrica";
            this.cbMetrica.Size = new System.Drawing.Size(121, 21);
            this.cbMetrica.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Métrica:";
            // 
            // txtQtdCompra
            // 
            this.txtQtdCompra.Location = new System.Drawing.Point(165, 92);
            this.txtQtdCompra.Name = "txtQtdCompra";
            this.txtQtdCompra.Size = new System.Drawing.Size(65, 20);
            this.txtQtdCompra.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Qtd. Compra:";
            // 
            // cbUnidadeCompra
            // 
            this.cbUnidadeCompra.FormattingEnabled = true;
            this.cbUnidadeCompra.Items.AddRange(new object[] {
            "Unidade",
            "Lata",
            "Caixa",
            "Balde"});
            this.cbUnidadeCompra.Location = new System.Drawing.Point(350, 53);
            this.cbUnidadeCompra.Name = "cbUnidadeCompra";
            this.cbUnidadeCompra.Size = new System.Drawing.Size(121, 21);
            this.cbUnidadeCompra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Unid. Compra:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(165, 18);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(253, 20);
            this.txtProduto.TabIndex = 7;
            // 
            // txtCustoProd
            // 
            this.txtCustoProd.Location = new System.Drawing.Point(165, 54);
            this.txtCustoProd.Name = "txtCustoProd";
            this.txtCustoProd.Size = new System.Drawing.Size(65, 20);
            this.txtCustoProd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Custo/Unid. (Reais):";
            // 
            // tbReceita
            // 
            this.tbReceita.BackColor = System.Drawing.Color.Transparent;
            this.tbReceita.BackgroundImage = global::wfaSistemadeControle.Properties.Resources._930543712_XG;
            this.tbReceita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbReceita.Controls.Add(this.btnGravarReceita);
            this.tbReceita.Controls.Add(this.dgReceitaFinal);
            this.tbReceita.Controls.Add(this.btnExcluirReceita);
            this.tbReceita.Controls.Add(this.btnAdicionarReceita);
            this.tbReceita.Controls.Add(this.dgProdutosReceita);
            this.tbReceita.Controls.Add(this.cbItensCardapio);
            this.tbReceita.Controls.Add(this.label9);
            this.tbReceita.Location = new System.Drawing.Point(4, 22);
            this.tbReceita.Name = "tbReceita";
            this.tbReceita.Padding = new System.Windows.Forms.Padding(3);
            this.tbReceita.Size = new System.Drawing.Size(593, 335);
            this.tbReceita.TabIndex = 2;
            this.tbReceita.Text = "Receita";
            this.tbReceita.Click += new System.EventHandler(this.tbReceita_Click);
            this.tbReceita.Enter += new System.EventHandler(this.tbReceita_Click);
            // 
            // btnGravarReceita
            // 
            this.btnGravarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarReceita.Location = new System.Drawing.Point(413, 47);
            this.btnGravarReceita.Name = "btnGravarReceita";
            this.btnGravarReceita.Size = new System.Drawing.Size(107, 26);
            this.btnGravarReceita.TabIndex = 18;
            this.btnGravarReceita.Text = "Gravar Receita";
            this.btnGravarReceita.UseVisualStyleBackColor = true;
            this.btnGravarReceita.Click += new System.EventHandler(this.btnGravarReceita_Click);
            // 
            // dgReceitaFinal
            // 
            this.dgReceitaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReceitaFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cardapioReceita,
            this.cod_produtoReceita2,
            this.qtd_utilizada});
            this.dgReceitaFinal.Location = new System.Drawing.Point(327, 79);
            this.dgReceitaFinal.Name = "dgReceitaFinal";
            this.dgReceitaFinal.Size = new System.Drawing.Size(249, 248);
            this.dgReceitaFinal.TabIndex = 17;
            this.dgReceitaFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReceitaFinal_CellContentClick);
            // 
            // cod_cardapioReceita
            // 
            this.cod_cardapioReceita.HeaderText = "Item";
            this.cod_cardapioReceita.Name = "cod_cardapioReceita";
            this.cod_cardapioReceita.ReadOnly = true;
            this.cod_cardapioReceita.Width = 50;
            // 
            // cod_produtoReceita2
            // 
            this.cod_produtoReceita2.HeaderText = "Produto";
            this.cod_produtoReceita2.Name = "cod_produtoReceita2";
            this.cod_produtoReceita2.ReadOnly = true;
            this.cod_produtoReceita2.Width = 50;
            // 
            // qtd_utilizada
            // 
            this.qtd_utilizada.HeaderText = "Qtde. Utilizada";
            this.qtd_utilizada.Name = "qtd_utilizada";
            // 
            // btnExcluirReceita
            // 
            this.btnExcluirReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirReceita.Location = new System.Drawing.Point(263, 195);
            this.btnExcluirReceita.Name = "btnExcluirReceita";
            this.btnExcluirReceita.Size = new System.Drawing.Size(58, 26);
            this.btnExcluirReceita.TabIndex = 16;
            this.btnExcluirReceita.Text = "<<";
            this.btnExcluirReceita.UseVisualStyleBackColor = true;
            this.btnExcluirReceita.Click += new System.EventHandler(this.btnExcluirReceita_Click);
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarReceita.Location = new System.Drawing.Point(263, 163);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(58, 26);
            this.btnAdicionarReceita.TabIndex = 15;
            this.btnAdicionarReceita.Text = ">>";
            this.btnAdicionarReceita.UseVisualStyleBackColor = true;
            this.btnAdicionarReceita.Click += new System.EventHandler(this.btnAdicionarReceita_Click);
            // 
            // dgProdutosReceita
            // 
            this.dgProdutosReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutosReceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_produtoReceita,
            this.nome_produtoReceita});
            this.dgProdutosReceita.Location = new System.Drawing.Point(8, 79);
            this.dgProdutosReceita.Name = "dgProdutosReceita";
            this.dgProdutosReceita.Size = new System.Drawing.Size(249, 248);
            this.dgProdutosReceita.TabIndex = 12;
            // 
            // cod_produtoReceita
            // 
            this.cod_produtoReceita.HeaderText = "Código";
            this.cod_produtoReceita.Name = "cod_produtoReceita";
            this.cod_produtoReceita.ReadOnly = true;
            this.cod_produtoReceita.Width = 50;
            // 
            // nome_produtoReceita
            // 
            this.nome_produtoReceita.HeaderText = "Produto";
            this.nome_produtoReceita.Name = "nome_produtoReceita";
            this.nome_produtoReceita.ReadOnly = true;
            this.nome_produtoReceita.Width = 170;
            // 
            // cbItensCardapio
            // 
            this.cbItensCardapio.FormattingEnabled = true;
            this.cbItensCardapio.Location = new System.Drawing.Point(97, 27);
            this.cbItensCardapio.Name = "cbItensCardapio";
            this.cbItensCardapio.Size = new System.Drawing.Size(177, 21);
            this.cbItensCardapio.TabIndex = 11;
            this.cbItensCardapio.SelectedIndexChanged += new System.EventHandler(this.cbItensCardapio_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cardápio:";
            // 
            // tbVendas
            // 
            this.tbVendas.BackColor = System.Drawing.Color.Transparent;
            this.tbVendas.BackgroundImage = global::wfaSistemadeControle.Properties.Resources._930543712_XG;
            this.tbVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbVendas.Controls.Add(this.btnConsultarTodas);
            this.tbVendas.Controls.Add(this.btnExcluirVendas);
            this.tbVendas.Controls.Add(this.btnConsultarVendas);
            this.tbVendas.Controls.Add(this.dgVendas);
            this.tbVendas.Controls.Add(this.btnInserirVenda);
            this.tbVendas.Controls.Add(this.txtQtdVendida);
            this.tbVendas.Controls.Add(this.label11);
            this.tbVendas.Controls.Add(this.cbVendasCardapio);
            this.tbVendas.Controls.Add(this.label12);
            this.tbVendas.Controls.Add(this.label10);
            this.tbVendas.Controls.Add(this.datePicker);
            this.tbVendas.Location = new System.Drawing.Point(4, 22);
            this.tbVendas.Name = "tbVendas";
            this.tbVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tbVendas.Size = new System.Drawing.Size(593, 335);
            this.tbVendas.TabIndex = 3;
            this.tbVendas.Text = "Vendas";
            this.tbVendas.Click += new System.EventHandler(this.tbVendas_Click);
            this.tbVendas.Enter += new System.EventHandler(this.tbVendas_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(135, 36);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(231, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.Value = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Data da venda:";
            // 
            // cbVendasCardapio
            // 
            this.cbVendasCardapio.FormattingEnabled = true;
            this.cbVendasCardapio.Location = new System.Drawing.Point(135, 77);
            this.cbVendasCardapio.Name = "cbVendasCardapio";
            this.cbVendasCardapio.Size = new System.Drawing.Size(177, 21);
            this.cbVendasCardapio.TabIndex = 14;
            this.cbVendasCardapio.SelectedIndexChanged += new System.EventHandler(this.cbVendasCardapio_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cardápio:";
            // 
            // txtQtdVendida
            // 
            this.txtQtdVendida.Location = new System.Drawing.Point(426, 78);
            this.txtQtdVendida.Name = "txtQtdVendida";
            this.txtQtdVendida.Size = new System.Drawing.Size(65, 20);
            this.txtQtdVendida.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Qtd. Vendida:";
            // 
            // btnInserirVenda
            // 
            this.btnInserirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirVenda.Location = new System.Drawing.Point(236, 120);
            this.btnInserirVenda.Name = "btnInserirVenda";
            this.btnInserirVenda.Size = new System.Drawing.Size(119, 26);
            this.btnInserirVenda.TabIndex = 19;
            this.btnInserirVenda.Text = "Inserir Venda";
            this.btnInserirVenda.UseVisualStyleBackColor = true;
            this.btnInserirVenda.Click += new System.EventHandler(this.btnInserirVenda_Click);
            // 
            // dgVendas
            // 
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.cod_cardVenda,
            this.nome_cardVenda,
            this.qtd});
            this.dgVendas.Location = new System.Drawing.Point(8, 177);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.Size = new System.Drawing.Size(430, 150);
            this.dgVendas.TabIndex = 20;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.Width = 110;
            // 
            // cod_cardVenda
            // 
            this.cod_cardVenda.HeaderText = "Cód. Cardápio";
            this.cod_cardVenda.Name = "cod_cardVenda";
            this.cod_cardVenda.Width = 60;
            // 
            // nome_cardVenda
            // 
            this.nome_cardVenda.HeaderText = "Item";
            this.nome_cardVenda.Name = "nome_cardVenda";
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Quantidade";
            this.qtd.Name = "qtd";
            this.qtd.Width = 70;
            // 
            // btnConsultarVendas
            // 
            this.btnConsultarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVendas.Location = new System.Drawing.Point(458, 187);
            this.btnConsultarVendas.Name = "btnConsultarVendas";
            this.btnConsultarVendas.Size = new System.Drawing.Size(111, 26);
            this.btnConsultarVendas.TabIndex = 21;
            this.btnConsultarVendas.Text = "Consultar";
            this.btnConsultarVendas.UseVisualStyleBackColor = true;
            this.btnConsultarVendas.Click += new System.EventHandler(this.btnConsultarVendas_Click);
            // 
            // btnExcluirVendas
            // 
            this.btnExcluirVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVendas.Location = new System.Drawing.Point(458, 219);
            this.btnExcluirVendas.Name = "btnExcluirVendas";
            this.btnExcluirVendas.Size = new System.Drawing.Size(111, 26);
            this.btnExcluirVendas.TabIndex = 23;
            this.btnExcluirVendas.Text = "Excluir";
            this.btnExcluirVendas.UseVisualStyleBackColor = true;
            this.btnExcluirVendas.Click += new System.EventHandler(this.btnExcluirVendas_Click);
            // 
            // btnConsultarTodas
            // 
            this.btnConsultarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTodas.Location = new System.Drawing.Point(458, 251);
            this.btnConsultarTodas.Name = "btnConsultarTodas";
            this.btnConsultarTodas.Size = new System.Drawing.Size(111, 67);
            this.btnConsultarTodas.TabIndex = 24;
            this.btnConsultarTodas.Text = "Consultar todas as vendas";
            this.btnConsultarTodas.UseVisualStyleBackColor = true;
            this.btnConsultarTodas.Click += new System.EventHandler(this.btnConsultarTodas_Click);
            // 
            // cod_produto
            // 
            this.cod_produto.HeaderText = "cod_produto";
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.Visible = false;
            // 
            // nome_produto
            // 
            this.nome_produto.HeaderText = "Produto";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            // 
            // custo_unidade
            // 
            this.custo_unidade.HeaderText = "Custo/Unid.";
            this.custo_unidade.Name = "custo_unidade";
            // 
            // unidade_compra
            // 
            this.unidade_compra.HeaderText = "Unidade";
            this.unidade_compra.Name = "unidade_compra";
            this.unidade_compra.ReadOnly = true;
            // 
            // qtd_compra
            // 
            this.qtd_compra.HeaderText = "Qtde.";
            this.qtd_compra.Name = "qtd_compra";
            // 
            // metrica
            // 
            this.metrica.HeaderText = "Métrica";
            this.metrica.Name = "metrica";
            this.metrica.ReadOnly = true;
            // 
            // tbCardapio
            // 
            this.tbCardapio.BackColor = System.Drawing.Color.Transparent;
            this.tbCardapio.BackgroundImage = global::wfaSistemadeControle.Properties.Resources._930543712_XG;
            this.tbCardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbCardapio.Controls.Add(this.btnCarregarImagem);
            this.tbCardapio.Controls.Add(this.imagemCardapio);
            this.tbCardapio.Controls.Add(this.label3);
            this.tbCardapio.Controls.Add(this.btnExcluir);
            this.tbCardapio.Controls.Add(this.btnEditar);
            this.tbCardapio.Controls.Add(this.btnConsultar);
            this.tbCardapio.Controls.Add(this.dgCardapio);
            this.tbCardapio.Controls.Add(this.btnadicionarCardapio);
            this.tbCardapio.Controls.Add(this.txtNomeProd);
            this.tbCardapio.Controls.Add(this.txtPreco);
            this.tbCardapio.Controls.Add(this.label2);
            this.tbCardapio.Controls.Add(this.label1);
            this.tbCardapio.Location = new System.Drawing.Point(4, 22);
            this.tbCardapio.Name = "tbCardapio";
            this.tbCardapio.Padding = new System.Windows.Forms.Padding(3);
            this.tbCardapio.Size = new System.Drawing.Size(593, 335);
            this.tbCardapio.TabIndex = 0;
            this.tbCardapio.Text = "Cardápio";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarImagem.Location = new System.Drawing.Point(497, 98);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(88, 45);
            this.btnCarregarImagem.TabIndex = 15;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // imagemCardapio
            // 
            this.imagemCardapio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemCardapio.BackColor = System.Drawing.Color.Black;
            this.imagemCardapio.Image = global::wfaSistemadeControle.Properties.Resources.noimage;
            this.imagemCardapio.Location = new System.Drawing.Point(497, 6);
            this.imagemCardapio.Name = "imagemCardapio";
            this.imagemCardapio.Size = new System.Drawing.Size(88, 86);
            this.imagemCardapio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemCardapio.TabIndex = 14;
            this.imagemCardapio.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Imagem:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(452, 238);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 26);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(452, 206);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 26);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(452, 174);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(135, 26);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgCardapio
            // 
            this.dgCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cardapio,
            this.nome_cardapio,
            this.preco_venda,
            this.cod_image});
            this.dgCardapio.Location = new System.Drawing.Point(8, 149);
            this.dgCardapio.Name = "dgCardapio";
            this.dgCardapio.Size = new System.Drawing.Size(438, 178);
            this.dgCardapio.TabIndex = 7;
            this.dgCardapio.DoubleClick += new System.EventHandler(this.dgCardapio_DoubleClick);
            // 
            // btnadicionarCardapio
            // 
            this.btnadicionarCardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarCardapio.Location = new System.Drawing.Point(193, 102);
            this.btnadicionarCardapio.Name = "btnadicionarCardapio";
            this.btnadicionarCardapio.Size = new System.Drawing.Size(143, 26);
            this.btnadicionarCardapio.TabIndex = 6;
            this.btnadicionarCardapio.Text = "Adicionar Cardápio";
            this.btnadicionarCardapio.UseVisualStyleBackColor = true;
            this.btnadicionarCardapio.Click += new System.EventHandler(this.btnadicionarCardapio_Click);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(97, 16);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(253, 20);
            this.txtNomeProd.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(97, 51);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(65, 20);
            this.txtPreco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço:";
            // 
            // cod_cardapio
            // 
            this.cod_cardapio.HeaderText = "cod_cardapio";
            this.cod_cardapio.Name = "cod_cardapio";
            this.cod_cardapio.Visible = false;
            this.cod_cardapio.Width = 150;
            // 
            // nome_cardapio
            // 
            this.nome_cardapio.HeaderText = "Item";
            this.nome_cardapio.Name = "nome_cardapio";
            this.nome_cardapio.Width = 280;
            // 
            // preco_venda
            // 
            this.preco_venda.HeaderText = "Preço";
            this.preco_venda.Name = "preco_venda";
            // 
            // cod_image
            // 
            this.cod_image.HeaderText = "cod_image";
            this.cod_image.Name = "cod_image";
            this.cod_image.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wfaSistemadeControle.Properties.Resources._930543712_XG;
            this.ClientSize = new System.Drawing.Size(601, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Controle Quiosque";
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tbProduto.ResumeLayout(false);
            this.tbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tbReceita.ResumeLayout(false);
            this.tbReceita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceitaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutosReceita)).EndInit();
            this.tbVendas.ResumeLayout(false);
            this.tbVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.tbCardapio.ResumeLayout(false);
            this.tbCardapio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCardapio;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbProduto;
        private System.Windows.Forms.Button btnadicionarCardapio;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgCardapio;
        private System.Windows.Forms.PictureBox imagemCardapio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.ComboBox cbMetrica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQtdCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUnidadeCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCustoProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.TabPage tbReceita;
        private System.Windows.Forms.ComboBox cbItensCardapio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgProdutosReceita;
        private System.Windows.Forms.DataGridView dgReceitaFinal;
        private System.Windows.Forms.Button btnExcluirReceita;
        private System.Windows.Forms.Button btnAdicionarReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cardapioReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produtoReceita2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_utilizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produtoReceita;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produtoReceita;
        private System.Windows.Forms.Button btnGravarReceita;
        private System.Windows.Forms.TabPage tbVendas;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox cbVendasCardapio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInserirVenda;
        private System.Windows.Forms.TextBox txtQtdVendida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConsultarVendas;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cardVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cardVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.Button btnExcluirVendas;
        private System.Windows.Forms.Button btnConsultarTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrica;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_image;
    }
}

