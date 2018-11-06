namespace wfaArquivoTexto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre com o arquivo ou diretório:";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(44, 49);
            this.tbEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(346, 22);
            this.tbEntrada.TabIndex = 1;
            this.tbEntrada.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            this.tbEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEntrada_KeyDown);
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(44, 79);
            this.tbSaida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSaida.Multiline = true;
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(346, 328);
            this.tbSaida.TabIndex = 2;
            this.tbSaida.Leave += new System.EventHandler(this.tbSaida_Leave);
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Location = new System.Drawing.Point(41, 420);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(93, 17);
            this.lblInformacoes.TabIndex = 3;
            this.lblInformacoes.Text = "Informações: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 516);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.tbSaida);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Busca de Arquivo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.Label lblInformacoes;
    }
}

