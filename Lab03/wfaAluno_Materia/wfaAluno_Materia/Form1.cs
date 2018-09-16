using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAluno_Materia
{
    public partial class Form1 : Form
    {
        int i = 0;
        Aluno al;
        Materia ma;
        List<Aluno> listaAlunos = new List<Aluno>();
        List<Materia> listaDisciplina = new List<Materia>();

        public Form1()
        {
            InitializeComponent();
        }

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (nome_aluno == alunos[i].getNome())
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;

            for (int i = 0; i < materias.Count(); i++)
            {
                if (nome_materia == materias[i].getNome())
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void edtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            if ((edtNome.Text == "") || (edtMatricula.Text == "") || (edtPeriodo.Text == ""))
            {
                MessageBox.Show("Preencha os campos vazios!");
            }
            else { 
                Aluno a = new Aluno(edtNome.Text, edtMatricula.Text, int.Parse(edtPeriodo.Text));
                listaAlunos.Add(a);

                listAlunos.Items.Add(a.getNome());
                MessageBox.Show("Aluno cadastrado com sucesso!");
                edtNome.Clear();
                edtMatricula.Clear();
                edtPeriodo.Clear();
            }
        }

        private void btnCadDisciplina_Click(object sender, EventArgs e)
        {
            if ((edtDisciplina.Text == "") || (edtCodigo.Text == ""))
            {
                MessageBox.Show("Preencha os campos vazios!");
            }
            else
            {
                Materia m = new Materia(edtDisciplina.Text, edtCodigo.Text);
                listaDisciplina.Add(m);
                MessageBox.Show("Disciplina cadastrada com sucesso!");
                edtCodigo.Clear();
                edtDisciplina.Clear();
            }
        }

        private void listAlunos_DoubleClick(object sender, EventArgs e)
        {
            if (listA.Text != "")
            {
                txtRelatorio.Enabled = false;
                al = achaAluno(listAlunos.Text, listaAlunos);
                lblAluno.Text = al.getNome() + " - " + al.getMatricula();
                txtRelatorio.Text = al.imprimeMaterias();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listA.Items.Clear();
            listM.Items.Clear();
            for (i = 0; i < listaAlunos.Count; i++)
            {
                listA.Items.Add(listaAlunos[i].getNome());
            }

            for (i = 0; i < listaDisciplina.Count; i++)
            {
                listM.Items.Add(listaDisciplina[i].getNome());
            }
        }

        private void btnmatricular_Click(object sender, EventArgs e)
        {
            if ((edtNomeCadastrar.Text == "") || (edtMateriaCadastrar.Text == ""))
            {
                MessageBox.Show("Impossível matrícular com campos vazios!");
            }
            else
            {
                al = achaAluno(edtNomeCadastrar.Text, listaAlunos);
                ma = achaMateria(edtMateriaCadastrar.Text, listaDisciplina);
                al.addMateria(ma);
                MessageBox.Show("Aluno matriculado na disciplina com sucesso!");
                edtNomeCadastrar.Clear();
                edtMateriaCadastrar.Clear();
            }
        }

        private void listA_DoubleClick(object sender, EventArgs e)
        {
            edtNomeCadastrar.Text = listA.Text;
        }

        private void listM_DoubleClick(object sender, EventArgs e)
        {
            edtMateriaCadastrar.Text = listM.Text;
        }
    }
}
