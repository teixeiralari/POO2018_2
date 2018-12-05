namespace wfaArquivoSequencial
{
    partial class Form1
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
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSNulo = new System.Windows.Forms.Button();
            this.btnSNegativo = new System.Windows.Forms.Button();
            this.btnSPositivos = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.tabCadastrosContas = new System.Windows.Forms.TabPage();
            this.btProximoRegistro = new System.Windows.Forms.Button();
            this.btAbrirArquivo = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btGravarRegistro = new System.Windows.Forms.Button();
            this.btCriarArquivo = new System.Windows.Forms.Button();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbUltimoNome = new System.Windows.Forms.TextBox();
            this.tbPrimeiroNome = new System.Windows.Forms.TextBox();
            this.tbConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabContas = new System.Windows.Forms.TabControl();
            this.tabRelatorio.SuspendLayout();
            this.tabCadastrosContas.SuspendLayout();
            this.tabContas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.tabRelatorio.Controls.Add(this.btnFechar);
            this.tabRelatorio.Controls.Add(this.btnSNulo);
            this.tabRelatorio.Controls.Add(this.btnSNegativo);
            this.tabRelatorio.Controls.Add(this.btnSPositivos);
            this.tabRelatorio.Controls.Add(this.btnAbrir);
            this.tabRelatorio.Controls.Add(this.txtRelatorio);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 25);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(804, 408);
            this.tabRelatorio.TabIndex = 1;
            this.tabRelatorio.Text = "Relatório de Contas";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 5;
            this.btnFechar.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(655, 318);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(141, 30);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar Arquivo";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.UseWaitCursor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSNulo
            // 
            this.btnSNulo.FlatAppearance.BorderSize = 5;
            this.btnSNulo.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSNulo.Location = new System.Drawing.Point(497, 318);
            this.btnSNulo.Name = "btnSNulo";
            this.btnSNulo.Size = new System.Drawing.Size(141, 30);
            this.btnSNulo.TabIndex = 5;
            this.btnSNulo.Text = "Saldos Nulos";
            this.btnSNulo.UseVisualStyleBackColor = true;
            this.btnSNulo.UseWaitCursor = true;
            this.btnSNulo.Click += new System.EventHandler(this.btnSNulo_Click);
            // 
            // btnSNegativo
            // 
            this.btnSNegativo.FlatAppearance.BorderSize = 5;
            this.btnSNegativo.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSNegativo.Location = new System.Drawing.Point(335, 318);
            this.btnSNegativo.Name = "btnSNegativo";
            this.btnSNegativo.Size = new System.Drawing.Size(141, 30);
            this.btnSNegativo.TabIndex = 4;
            this.btnSNegativo.Text = "Saldos Negativos";
            this.btnSNegativo.UseVisualStyleBackColor = true;
            this.btnSNegativo.UseWaitCursor = true;
            this.btnSNegativo.Click += new System.EventHandler(this.btnSNegativo_Click);
            // 
            // btnSPositivos
            // 
            this.btnSPositivos.FlatAppearance.BorderSize = 5;
            this.btnSPositivos.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPositivos.Location = new System.Drawing.Point(171, 318);
            this.btnSPositivos.Name = "btnSPositivos";
            this.btnSPositivos.Size = new System.Drawing.Size(141, 30);
            this.btnSPositivos.TabIndex = 3;
            this.btnSPositivos.Text = "Saldos Positivos";
            this.btnSPositivos.UseVisualStyleBackColor = true;
            this.btnSPositivos.UseWaitCursor = true;
            this.btnSPositivos.Click += new System.EventHandler(this.btnSPositivos_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatAppearance.BorderSize = 5;
            this.btnAbrir.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(8, 318);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(141, 30);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.UseWaitCursor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Location = new System.Drawing.Point(8, 25);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(788, 276);
            this.txtRelatorio.TabIndex = 0;
            this.txtRelatorio.TextChanged += new System.EventHandler(this.txtRelatorio_TextChanged);
            // 
            // tabCadastrosContas
            // 
            this.tabCadastrosContas.BackColor = System.Drawing.Color.Transparent;
            this.tabCadastrosContas.Controls.Add(this.btProximoRegistro);
            this.tabCadastrosContas.Controls.Add(this.btAbrirArquivo);
            this.tabCadastrosContas.Controls.Add(this.btSair);
            this.tabCadastrosContas.Controls.Add(this.btGravarRegistro);
            this.tabCadastrosContas.Controls.Add(this.btCriarArquivo);
            this.tabCadastrosContas.Controls.Add(this.tbSaldo);
            this.tabCadastrosContas.Controls.Add(this.tbUltimoNome);
            this.tabCadastrosContas.Controls.Add(this.tbPrimeiroNome);
            this.tabCadastrosContas.Controls.Add(this.tbConta);
            this.tabCadastrosContas.Controls.Add(this.label4);
            this.tabCadastrosContas.Controls.Add(this.label3);
            this.tabCadastrosContas.Controls.Add(this.label2);
            this.tabCadastrosContas.Controls.Add(this.label1);
            this.tabCadastrosContas.Location = new System.Drawing.Point(4, 25);
            this.tabCadastrosContas.Name = "tabCadastrosContas";
            this.tabCadastrosContas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrosContas.Size = new System.Drawing.Size(804, 408);
            this.tabCadastrosContas.TabIndex = 0;
            this.tabCadastrosContas.Text = "Contas";
            // 
            // btProximoRegistro
            // 
            this.btProximoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximoRegistro.Location = new System.Drawing.Point(338, 284);
            this.btProximoRegistro.Name = "btProximoRegistro";
            this.btProximoRegistro.Size = new System.Drawing.Size(141, 30);
            this.btProximoRegistro.TabIndex = 25;
            this.btProximoRegistro.Text = "Próximo Registro";
            this.btProximoRegistro.UseVisualStyleBackColor = true;
            this.btProximoRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btProximoRegistro_MouseClick);
            // 
            // btAbrirArquivo
            // 
            this.btAbrirArquivo.AutoEllipsis = true;
            this.btAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirArquivo.Location = new System.Drawing.Point(338, 248);
            this.btAbrirArquivo.Name = "btAbrirArquivo";
            this.btAbrirArquivo.Size = new System.Drawing.Size(141, 30);
            this.btAbrirArquivo.TabIndex = 24;
            this.btAbrirArquivo.Text = "Abrir Arquivo";
            this.btAbrirArquivo.UseVisualStyleBackColor = true;
            this.btAbrirArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAbrirArquivo_MouseClick);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(654, 267);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(141, 30);
            this.btSair.TabIndex = 23;
            this.btSair.Text = "Fechar Arquivo";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btSair_MouseClick);
            // 
            // btGravarRegistro
            // 
            this.btGravarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarRegistro.Location = new System.Drawing.Point(30, 286);
            this.btGravarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btGravarRegistro.Name = "btGravarRegistro";
            this.btGravarRegistro.Size = new System.Drawing.Size(141, 30);
            this.btGravarRegistro.TabIndex = 22;
            this.btGravarRegistro.Text = "Gravar Registro";
            this.btGravarRegistro.UseVisualStyleBackColor = true;
            this.btGravarRegistro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btGravarRegistro_MouseClick);
            // 
            // btCriarArquivo
            // 
            this.btCriarArquivo.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.btCriarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriarArquivo.Location = new System.Drawing.Point(30, 248);
            this.btCriarArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.btCriarArquivo.Name = "btCriarArquivo";
            this.btCriarArquivo.Size = new System.Drawing.Size(141, 30);
            this.btCriarArquivo.TabIndex = 21;
            this.btCriarArquivo.Text = "Criar Arquivo";
            this.btCriarArquivo.UseVisualStyleBackColor = true;
            this.btCriarArquivo.Click += new System.EventHandler(this.btCriarArquivo_Click);
            this.btCriarArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCriarArquivo_MouseClick);
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(367, 189);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(239, 22);
            this.tbSaldo.TabIndex = 20;
            // 
            // tbUltimoNome
            // 
            this.tbUltimoNome.Location = new System.Drawing.Point(367, 129);
            this.tbUltimoNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbUltimoNome.Name = "tbUltimoNome";
            this.tbUltimoNome.Size = new System.Drawing.Size(239, 22);
            this.tbUltimoNome.TabIndex = 19;
            // 
            // tbPrimeiroNome
            // 
            this.tbPrimeiroNome.Location = new System.Drawing.Point(367, 71);
            this.tbPrimeiroNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrimeiroNome.Name = "tbPrimeiroNome";
            this.tbPrimeiroNome.Size = new System.Drawing.Size(239, 22);
            this.tbPrimeiroNome.TabIndex = 18;
            // 
            // tbConta
            // 
            this.tbConta.Location = new System.Drawing.Point(367, 19);
            this.tbConta.Margin = new System.Windows.Forms.Padding(4);
            this.tbConta.Name = "tbConta";
            this.tbConta.Size = new System.Drawing.Size(239, 22);
            this.tbConta.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Último Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Primeiro Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Conta:";
            // 
            // tabContas
            // 
            this.tabContas.Controls.Add(this.tabCadastrosContas);
            this.tabContas.Controls.Add(this.tabRelatorio);
            this.tabContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContas.Location = new System.Drawing.Point(0, 0);
            this.tabContas.Name = "tabContas";
            this.tabContas.SelectedIndex = 0;
            this.tabContas.Size = new System.Drawing.Size(812, 437);
            this.tabContas.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 437);
            this.Controls.Add(this.tabContas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gerenciador de Contas";
            this.tabRelatorio.ResumeLayout(false);
            this.tabRelatorio.PerformLayout();
            this.tabCadastrosContas.ResumeLayout(false);
            this.tabCadastrosContas.PerformLayout();
            this.tabContas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSNulo;
        private System.Windows.Forms.Button btnSNegativo;
        private System.Windows.Forms.Button btnSPositivos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.TabPage tabCadastrosContas;
        private System.Windows.Forms.Button btProximoRegistro;
        private System.Windows.Forms.Button btAbrirArquivo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btGravarRegistro;
        private System.Windows.Forms.Button btCriarArquivo;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbUltimoNome;
        private System.Windows.Forms.TextBox tbPrimeiroNome;
        private System.Windows.Forms.TextBox tbConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabContas;
    }
}

