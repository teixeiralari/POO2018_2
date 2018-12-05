namespace wfaArquivosExemplos
{
    partial class frmArquivos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.btnGravarArquivo = new System.Windows.Forms.Button();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.txtCursoFormacao = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRelatorio = new System.Windows.Forms.TabPage();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbProfessorRel = new System.Windows.Forms.RadioButton();
            this.rbAlunoRel = new System.Windows.Forms.RadioButton();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbRelatorio);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 328);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnFechar);
            this.tabPage1.Controls.Add(this.btnLerArquivo);
            this.tabPage1.Controls.Add(this.btnGravarArquivo);
            this.tabPage1.Controls.Add(this.btnAbrirArquivo);
            this.tabPage1.Controls.Add(this.btnCriarArquivo);
            this.tabPage1.Controls.Add(this.txtCursoFormacao);
            this.tabPage1.Controls.Add(this.lblTipo);
            this.tabPage1.Controls.Add(this.txtEnd);
            this.tabPage1.Controls.Add(this.txtIdade);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.rbProfessor);
            this.tabPage1.Controls.Add(this.rbAluno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(459, 239);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(116, 31);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar Arquivo";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(243, 260);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(116, 31);
            this.btnLerArquivo.TabIndex = 18;
            this.btnLerArquivo.Text = "Ler registros";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnGravarArquivo
            // 
            this.btnGravarArquivo.Location = new System.Drawing.Point(6, 260);
            this.btnGravarArquivo.Name = "btnGravarArquivo";
            this.btnGravarArquivo.Size = new System.Drawing.Size(116, 31);
            this.btnGravarArquivo.TabIndex = 17;
            this.btnGravarArquivo.Text = "Gravar arquivo";
            this.btnGravarArquivo.UseVisualStyleBackColor = true;
            this.btnGravarArquivo.Click += new System.EventHandler(this.btnGravarArquivo_Click);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(243, 225);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(116, 31);
            this.btnAbrirArquivo.TabIndex = 16;
            this.btnAbrirArquivo.Text = "Abrir arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(6, 225);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(116, 31);
            this.btnCriarArquivo.TabIndex = 15;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // txtCursoFormacao
            // 
            this.txtCursoFormacao.Location = new System.Drawing.Point(102, 187);
            this.txtCursoFormacao.Name = "txtCursoFormacao";
            this.txtCursoFormacao.Size = new System.Drawing.Size(473, 22);
            this.txtCursoFormacao.TabIndex = 14;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 187);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 17);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Curso:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(102, 151);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(473, 22);
            this.txtEnd.TabIndex = 12;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(102, 117);
            this.txtIdade.MaxLength = 2;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(61, 22);
            this.txtIdade.TabIndex = 11;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(473, 22);
            this.txtNome.TabIndex = 10;
            // 
            // rbProfessor
            // 
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.Location = new System.Drawing.Point(156, 25);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(90, 21);
            this.rbProfessor.TabIndex = 9;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.UseVisualStyleBackColor = true;
            this.rbProfessor.Click += new System.EventHandler(this.rbProfessor_Click);
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Location = new System.Drawing.Point(374, 25);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(65, 21);
            this.rbAluno.TabIndex = 8;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            this.rbAluno.Click += new System.EventHandler(this.rbAluno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.tbRelatorio.Controls.Add(this.btnGerar);
            this.tbRelatorio.Controls.Add(this.btnBuscar);
            this.tbRelatorio.Controls.Add(this.rbProfessorRel);
            this.tbRelatorio.Controls.Add(this.rbAlunoRel);
            this.tbRelatorio.Controls.Add(this.txtRelatorio);
            this.tbRelatorio.Location = new System.Drawing.Point(4, 25);
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tbRelatorio.Size = new System.Drawing.Size(620, 299);
            this.tbRelatorio.TabIndex = 1;
            this.tbRelatorio.Text = "Relatórios";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(284, 40);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(116, 31);
            this.btnGerar.TabIndex = 17;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(284, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar arquivo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbProfessorRel
            // 
            this.rbProfessorRel.AutoSize = true;
            this.rbProfessorRel.Location = new System.Drawing.Point(133, 18);
            this.rbProfessorRel.Name = "rbProfessorRel";
            this.rbProfessorRel.Size = new System.Drawing.Size(90, 21);
            this.rbProfessorRel.TabIndex = 11;
            this.rbProfessorRel.TabStop = true;
            this.rbProfessorRel.Text = "Professor";
            this.rbProfessorRel.UseVisualStyleBackColor = true;
            // 
            // rbAlunoRel
            // 
            this.rbAlunoRel.AutoSize = true;
            this.rbAlunoRel.Location = new System.Drawing.Point(133, 45);
            this.rbAlunoRel.Name = "rbAlunoRel";
            this.rbAlunoRel.Size = new System.Drawing.Size(65, 21);
            this.rbAlunoRel.TabIndex = 10;
            this.rbAlunoRel.Text = "Aluno";
            this.rbAlunoRel.UseVisualStyleBackColor = true;
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Location = new System.Drawing.Point(8, 83);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(604, 195);
            this.txtRelatorio.TabIndex = 0;
            // 
            // frmArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 328);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmArquivos";
            this.Text = "Arquivos";
            this.Shown += new System.EventHandler(this.frmArquivos_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbRelatorio.ResumeLayout(false);
            this.tbRelatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCursoFormacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbProfessor;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbRelatorio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.Button btnGravarArquivo;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbProfessorRel;
        private System.Windows.Forms.RadioButton rbAlunoRel;
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.Button btnGerar;
    }
}

