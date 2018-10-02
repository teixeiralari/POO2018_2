namespace wfaEmpregado
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edtvalor = new System.Windows.Forms.TextBox();
            this.edthoras = new System.Windows.Forms.TextBox();
            this.edtsalario = new System.Windows.Forms.TextBox();
            this.edtend = new System.Windows.Forms.TextBox();
            this.edtcpf = new System.Windows.Forms.TextBox();
            this.edtnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbHorista = new System.Windows.Forms.RadioButton();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.lbRelatorio = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 421);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbRelatorio);
            this.tabPage1.Controls.Add(this.btnRelatorio);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relatório";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edtvalor);
            this.tabPage2.Controls.Add(this.edthoras);
            this.tabPage2.Controls.Add(this.edtsalario);
            this.tabPage2.Controls.Add(this.edtend);
            this.tabPage2.Controls.Add(this.edtcpf);
            this.tabPage2.Controls.Add(this.edtnome);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnCadastrar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edtvalor
            // 
            this.edtvalor.Location = new System.Drawing.Point(424, 223);
            this.edtvalor.Margin = new System.Windows.Forms.Padding(4);
            this.edtvalor.Name = "edtvalor";
            this.edtvalor.Size = new System.Drawing.Size(111, 22);
            this.edtvalor.TabIndex = 27;
            this.edtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtvalor_KeyPress);
            // 
            // edthoras
            // 
            this.edthoras.Location = new System.Drawing.Point(157, 223);
            this.edthoras.Margin = new System.Windows.Forms.Padding(4);
            this.edthoras.Name = "edthoras";
            this.edthoras.Size = new System.Drawing.Size(111, 22);
            this.edthoras.TabIndex = 26;
            this.edthoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edthoras_KeyPress);
            // 
            // edtsalario
            // 
            this.edtsalario.Location = new System.Drawing.Point(110, 175);
            this.edtsalario.Margin = new System.Windows.Forms.Padding(4);
            this.edtsalario.Name = "edtsalario";
            this.edtsalario.Size = new System.Drawing.Size(111, 22);
            this.edtsalario.TabIndex = 25;
            this.edtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtsalario_KeyPress);
            // 
            // edtend
            // 
            this.edtend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtend.Location = new System.Drawing.Point(110, 130);
            this.edtend.Margin = new System.Windows.Forms.Padding(4);
            this.edtend.Name = "edtend";
            this.edtend.Size = new System.Drawing.Size(352, 22);
            this.edtend.TabIndex = 24;
            // 
            // edtcpf
            // 
            this.edtcpf.Location = new System.Drawing.Point(110, 85);
            this.edtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.edtcpf.MaxLength = 14;
            this.edtcpf.Name = "edtcpf";
            this.edtcpf.Size = new System.Drawing.Size(352, 22);
            this.edtcpf.TabIndex = 23;
            this.edtcpf.TextChanged += new System.EventHandler(this.edtcpf_TextChanged);
            this.edtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtcpf_KeyPress);
            // 
            // edtnome
            // 
            this.edtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtnome.Location = new System.Drawing.Point(110, 40);
            this.edtnome.Margin = new System.Windows.Forms.Padding(4);
            this.edtnome.Name = "edtnome";
            this.edtnome.Size = new System.Drawing.Size(352, 22);
            this.edtnome.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor da hora (R$): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Número de horas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(82, 342);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(583, 28);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCLT);
            this.groupBox1.Controls.Add(this.rbHorista);
            this.groupBox1.Location = new System.Drawing.Point(506, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(208, 151);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(8, 85);
            this.rbCLT.Margin = new System.Windows.Forms.Padding(4);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(132, 21);
            this.rbCLT.TabIndex = 1;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "Empregado CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            this.rbCLT.CheckedChanged += new System.EventHandler(this.rbCLT_CheckedChanged);
            // 
            // rbHorista
            // 
            this.rbHorista.AutoSize = true;
            this.rbHorista.Location = new System.Drawing.Point(8, 44);
            this.rbHorista.Margin = new System.Windows.Forms.Padding(4);
            this.rbHorista.Name = "rbHorista";
            this.rbHorista.Size = new System.Drawing.Size(151, 21);
            this.rbHorista.TabIndex = 0;
            this.rbHorista.TabStop = true;
            this.rbHorista.Text = "Empregado Horista";
            this.rbHorista.UseVisualStyleBackColor = true;
            this.rbHorista.CheckedChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(211, 21);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(303, 47);
            this.btnRelatorio.TabIndex = 0;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // lbRelatorio
            // 
            this.lbRelatorio.FormattingEnabled = true;
            this.lbRelatorio.ItemHeight = 16;
            this.lbRelatorio.Location = new System.Drawing.Point(6, 106);
            this.lbRelatorio.Name = "lbRelatorio";
            this.lbRelatorio.Size = new System.Drawing.Size(742, 276);
            this.lbRelatorio.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 421);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sistema de cadastro de empregado";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox edtvalor;
        private System.Windows.Forms.TextBox edthoras;
        private System.Windows.Forms.TextBox edtsalario;
        private System.Windows.Forms.TextBox edtend;
        private System.Windows.Forms.TextBox edtcpf;
        private System.Windows.Forms.TextBox edtnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.RadioButton rbHorista;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.ListBox lbRelatorio;
    }
}

