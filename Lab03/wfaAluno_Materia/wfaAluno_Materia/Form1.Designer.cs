namespace wfaAluno_Materia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabsheet = new System.Windows.Forms.TabControl();
            this.tbAluno = new System.Windows.Forms.TabPage();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.edtPeriodo = new System.Windows.Forms.TextBox();
            this.edtMatricula = new System.Windows.Forms.TextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMateria = new System.Windows.Forms.TabPage();
            this.btnCadDisciplina = new System.Windows.Forms.Button();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            this.edtDisciplina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRelatorio = new System.Windows.Forms.TabPage();
            this.lblAluno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listAlunos = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPesquisaAM = new System.Windows.Forms.Button();
            this.btnmatricular = new System.Windows.Forms.Button();
            this.edtMateriaCadastrar = new System.Windows.Forms.TextBox();
            this.edtNomeCadastrar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listM = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listA = new System.Windows.Forms.ListBox();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabsheet.SuspendLayout();
            this.tbAluno.SuspendLayout();
            this.tbMateria.SuspendLayout();
            this.tbRelatorio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabsheet);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 487);
            this.panel1.TabIndex = 0;
            // 
            // tabsheet
            // 
            this.tabsheet.Controls.Add(this.tbAluno);
            this.tabsheet.Controls.Add(this.tbMateria);
            this.tabsheet.Controls.Add(this.tabPage1);
            this.tabsheet.Controls.Add(this.tbRelatorio);
            this.tabsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsheet.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsheet.ItemSize = new System.Drawing.Size(48, 22);
            this.tabsheet.Location = new System.Drawing.Point(0, 0);
            this.tabsheet.Name = "tabsheet";
            this.tabsheet.SelectedIndex = 0;
            this.tabsheet.Size = new System.Drawing.Size(857, 487);
            this.tabsheet.TabIndex = 0;
            // 
            // tbAluno
            // 
            this.tbAluno.BackColor = System.Drawing.SystemColors.Control;
            this.tbAluno.Controls.Add(this.btnCadAluno);
            this.tbAluno.Controls.Add(this.edtPeriodo);
            this.tbAluno.Controls.Add(this.edtMatricula);
            this.tbAluno.Controls.Add(this.edtNome);
            this.tbAluno.Controls.Add(this.label4);
            this.tbAluno.Controls.Add(this.label3);
            this.tbAluno.Controls.Add(this.label2);
            this.tbAluno.Controls.Add(this.label1);
            this.tbAluno.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAluno.Location = new System.Drawing.Point(4, 26);
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tbAluno.Size = new System.Drawing.Size(849, 457);
            this.tbAluno.TabIndex = 0;
            this.tbAluno.Text = "Aluno";
            this.tbAluno.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadAluno.AutoSize = true;
            this.btnCadAluno.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadAluno.Location = new System.Drawing.Point(295, 365);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(127, 32);
            this.btnCadAluno.TabIndex = 7;
            this.btnCadAluno.Text = "Cadastrar";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // edtPeriodo
            // 
            this.edtPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPeriodo.Location = new System.Drawing.Point(125, 176);
            this.edtPeriodo.MaxLength = 2;
            this.edtPeriodo.Name = "edtPeriodo";
            this.edtPeriodo.Size = new System.Drawing.Size(82, 27);
            this.edtPeriodo.TabIndex = 6;
            this.edtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtPeriodo_KeyPress);
            // 
            // edtMatricula
            // 
            this.edtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMatricula.Location = new System.Drawing.Point(125, 122);
            this.edtMatricula.MaxLength = 20;
            this.edtMatricula.Name = "edtMatricula";
            this.edtMatricula.Size = new System.Drawing.Size(339, 27);
            this.edtMatricula.TabIndex = 5;
            // 
            // edtNome
            // 
            this.edtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNome.Location = new System.Drawing.Point(125, 69);
            this.edtNome.MaxLength = 256;
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(472, 27);
            this.edtNome.TabIndex = 4;
            this.edtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Período:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR ALUNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbMateria
            // 
            this.tbMateria.BackColor = System.Drawing.SystemColors.Control;
            this.tbMateria.Controls.Add(this.btnCadDisciplina);
            this.tbMateria.Controls.Add(this.edtCodigo);
            this.tbMateria.Controls.Add(this.edtDisciplina);
            this.tbMateria.Controls.Add(this.label5);
            this.tbMateria.Controls.Add(this.label6);
            this.tbMateria.Controls.Add(this.label7);
            this.tbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMateria.Location = new System.Drawing.Point(4, 26);
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tbMateria.Size = new System.Drawing.Size(849, 457);
            this.tbMateria.TabIndex = 1;
            this.tbMateria.Text = "Disciplina";
            // 
            // btnCadDisciplina
            // 
            this.btnCadDisciplina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadDisciplina.AutoSize = true;
            this.btnCadDisciplina.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadDisciplina.Location = new System.Drawing.Point(271, 325);
            this.btnCadDisciplina.Name = "btnCadDisciplina";
            this.btnCadDisciplina.Size = new System.Drawing.Size(164, 42);
            this.btnCadDisciplina.TabIndex = 11;
            this.btnCadDisciplina.Text = "Cadastrar";
            this.btnCadDisciplina.UseVisualStyleBackColor = true;
            this.btnCadDisciplina.Click += new System.EventHandler(this.btnCadDisciplina_Click);
            // 
            // edtCodigo
            // 
            this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCodigo.Location = new System.Drawing.Point(166, 169);
            this.edtCodigo.MaxLength = 20;
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.Size = new System.Drawing.Size(339, 27);
            this.edtCodigo.TabIndex = 10;
            // 
            // edtDisciplina
            // 
            this.edtDisciplina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDisciplina.Location = new System.Drawing.Point(166, 99);
            this.edtDisciplina.MaxLength = 256;
            this.edtDisciplina.Name = "edtDisciplina";
            this.edtDisciplina.Size = new System.Drawing.Size(404, 27);
            this.edtDisciplina.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Disciplina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 21);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "CADASTRAR DISCIPLINA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.tbRelatorio.Controls.Add(this.txtRelatorio);
            this.tbRelatorio.Controls.Add(this.lblAluno);
            this.tbRelatorio.Controls.Add(this.label9);
            this.tbRelatorio.Controls.Add(this.label8);
            this.tbRelatorio.Controls.Add(this.listAlunos);
            this.tbRelatorio.Location = new System.Drawing.Point(4, 26);
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tbRelatorio.Size = new System.Drawing.Size(849, 457);
            this.tbRelatorio.TabIndex = 2;
            this.tbRelatorio.Text = "Relatório";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(324, 118);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(209, 22);
            this.lblAluno.TabIndex = 9;
            this.lblAluno.Text = "Nenhum aluno escolhido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 118);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(269, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Disciplinas referente ao Aluno: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 19);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(223, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "ALUNOS MATRICULADOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listAlunos
            // 
            this.listAlunos.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAlunos.FormattingEnabled = true;
            this.listAlunos.ItemHeight = 25;
            this.listAlunos.Location = new System.Drawing.Point(24, 54);
            this.listAlunos.Name = "listAlunos";
            this.listAlunos.Size = new System.Drawing.Size(522, 29);
            this.listAlunos.TabIndex = 0;
            this.listAlunos.DoubleClick += new System.EventHandler(this.listAlunos_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnPesquisaAM);
            this.tabPage1.Controls.Add(this.btnmatricular);
            this.tabPage1.Controls.Add(this.edtMateriaCadastrar);
            this.tabPage1.Controls.Add(this.edtNomeCadastrar);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.listM);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.listA);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 457);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Matricular";
            // 
            // btnPesquisaAM
            // 
            this.btnPesquisaAM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaAM.Location = new System.Drawing.Point(457, 110);
            this.btnPesquisaAM.Name = "btnPesquisaAM";
            this.btnPesquisaAM.Size = new System.Drawing.Size(196, 60);
            this.btnPesquisaAM.TabIndex = 21;
            this.btnPesquisaAM.Text = "Pesquisar Alunos e Disciplinas";
            this.btnPesquisaAM.UseVisualStyleBackColor = true;
            this.btnPesquisaAM.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmatricular
            // 
            this.btnmatricular.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatricular.Location = new System.Drawing.Point(261, 369);
            this.btnmatricular.Name = "btnmatricular";
            this.btnmatricular.Size = new System.Drawing.Size(172, 43);
            this.btnmatricular.TabIndex = 20;
            this.btnmatricular.Text = "Matricular";
            this.btnmatricular.UseVisualStyleBackColor = true;
            this.btnmatricular.Click += new System.EventHandler(this.btnmatricular_Click);
            // 
            // edtMateriaCadastrar
            // 
            this.edtMateriaCadastrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtMateriaCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMateriaCadastrar.Location = new System.Drawing.Point(457, 294);
            this.edtMateriaCadastrar.Name = "edtMateriaCadastrar";
            this.edtMateriaCadastrar.Size = new System.Drawing.Size(196, 29);
            this.edtMateriaCadastrar.TabIndex = 19;
            // 
            // edtNomeCadastrar
            // 
            this.edtNomeCadastrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edtNomeCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNomeCadastrar.Location = new System.Drawing.Point(192, 230);
            this.edtNomeCadastrar.Name = "edtNomeCadastrar";
            this.edtNomeCadastrar.Size = new System.Drawing.Size(461, 29);
            this.edtNomeCadastrar.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(348, 22);
            this.label13.TabIndex = 17;
            this.label13.Text = "Disciplina que deseja matricular o aluno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nome do aluno:";
            // 
            // listM
            // 
            this.listM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listM.FormattingEnabled = true;
            this.listM.ItemHeight = 22;
            this.listM.Location = new System.Drawing.Point(31, 157);
            this.listM.Name = "listM";
            this.listM.Size = new System.Drawing.Size(365, 26);
            this.listM.TabIndex = 15;
            this.listM.DoubleClick += new System.EventHandler(this.listM_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 126);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(245, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "DISCIPLINAS CADASTRADAS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 16);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(214, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "ALUNOS CADASTRADOS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listA
            // 
            this.listA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listA.FormattingEnabled = true;
            this.listA.ItemHeight = 22;
            this.listA.Location = new System.Drawing.Point(31, 47);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(491, 26);
            this.listA.TabIndex = 11;
            this.listA.DoubleClick += new System.EventHandler(this.listA_DoubleClick);
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Enabled = false;
            this.txtRelatorio.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorio.Location = new System.Drawing.Point(24, 161);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(390, 257);
            this.txtRelatorio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 484);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cadastro Aluno/Materia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabsheet.ResumeLayout(false);
            this.tbAluno.ResumeLayout(false);
            this.tbAluno.PerformLayout();
            this.tbMateria.ResumeLayout(false);
            this.tbMateria.PerformLayout();
            this.tbRelatorio.ResumeLayout(false);
            this.tbRelatorio.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabsheet;
        private System.Windows.Forms.TabPage tbAluno;
        private System.Windows.Forms.TabPage tbMateria;
        private System.Windows.Forms.TextBox edtPeriodo;
        private System.Windows.Forms.TextBox edtMatricula;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbRelatorio;
        private System.Windows.Forms.Button btnCadAluno;
        private System.Windows.Forms.Button btnCadDisciplina;
        private System.Windows.Forms.TextBox edtCodigo;
        private System.Windows.Forms.TextBox edtDisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listAlunos;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPesquisaAM;
        private System.Windows.Forms.Button btnmatricular;
        private System.Windows.Forms.TextBox edtMateriaCadastrar;
        private System.Windows.Forms.TextBox edtNomeCadastrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listA;
        private System.Windows.Forms.TextBox txtRelatorio;
    }
}

