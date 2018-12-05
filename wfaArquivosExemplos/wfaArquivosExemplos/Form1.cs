using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace wfaArquivosExemplos
{
    public partial class frmArquivos : Form
    {
        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();
        string filename;
        private FileStream arquivo;

        List<Aluno> listAluno = new List<Aluno>();
        List<Professor> listProfessor = new List<Professor>();

        public frmArquivos()
        {
            InitializeComponent();
        }

        private void rbProfessor_Click(object sender, EventArgs e)
        {
            lblTipo.Text = "Formação: ";
        }

        private void rbAluno_Click(object sender, EventArgs e)
        {
            lblTipo.Text = "Curso:";
        }

        private void frmArquivos_Shown(object sender, EventArgs e)
        {
            btnGravarArquivo.Enabled = false;
            btnAbrirArquivo.Enabled = true;
            btnFechar.Enabled = false;
            btnLerArquivo.Enabled = false;
            btnCriarArquivo.Enabled = true;
            rbAluno.Checked = false;
            rbProfessor.Checked = false;
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            filename = "";
            SaveFileDialog fileChooser = new SaveFileDialog();
            DialogResult pathArquivo = fileChooser.ShowDialog();

            if (pathArquivo == DialogResult.OK)
            {
                filename = fileChooser.FileName;
                MessageBox.Show(filename, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;

            if (filename == "" || filename == null)
                MessageBox.Show("Nome de Arquivo Inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // save file via FileStream if user specified valid file
                try
                {
                    // open file with write access
                    arquivo = new FileStream(filename,
                       FileMode.OpenOrCreate, FileAccess.Write);
                 
                }

                // handle exception if file does not exist
                catch (FileNotFoundException)
                {
                    // notify user if file does not exist
                    MessageBox.Show("Arquivo não existe", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGravarArquivo.Enabled = true;
            btnAbrirArquivo.Enabled = false;
            btnFechar.Enabled = false;
            btnLerArquivo.Enabled = false;
            btnCriarArquivo.Enabled = false;
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            filename = "";
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult pathArquivo = fileChooser.ShowDialog();

            filename = fileChooser.FileName;

            if (filename == "" || filename == null)
                MessageBox.Show("Nome de Arquivo Inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    // open file with write access
                    arquivo = new FileStream(filename,
                       FileMode.Open, FileAccess.Read);
                }

                // handle exception if file does not exist
                catch (FileNotFoundException)
                {
                    // notify user if file does not exist
                    MessageBox.Show("Arquivo não existe", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGravarArquivo.Enabled = false;
            btnAbrirArquivo.Enabled = false;
            btnFechar.Enabled = true;
            btnLerArquivo.Enabled = true;
        }

        private void btnGravarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAluno.Checked == true)
                {
                    Aluno aluno = new Aluno();
                    aluno.setNome(txtNome.Text);
                    aluno.setEndereco(txtEnd.Text);
                    aluno.setIdade(Convert.ToInt32(txtIdade.Text));
                    aluno.setCurso(txtCursoFormacao.Text);

                    

                    formatter.Serialize(arquivo, aluno);
                }

                else
                {
                    Professor professor = new Professor();
                    professor.setNome(txtNome.Text);
                    professor.setEndereco(txtEnd.Text);
                    professor.setIdade(Convert.ToInt32(txtIdade.Text));
                    professor.setFormacao(txtCursoFormacao.Text);

                    formatter.Serialize(arquivo, professor);
                }

                MessageBox.Show("Registro salvo com sucesso!", "Informação",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SerializationException)
            {
                MessageBox.Show("Erro ao escrever no arquivo", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // notifica o usuário sobre erro de formato
            catch (FormatException)
            {
                MessageBox.Show("Formato Inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNome.Text = "";
            txtIdade.Text = "";
            txtEnd.Text = "";
            txtCursoFormacao.Text = "";

            btnGravarArquivo.Enabled = true;
            btnAbrirArquivo.Enabled = false;
            btnFechar.Enabled = true;
            btnLerArquivo.Enabled = false;
            btnCriarArquivo.Enabled = false;
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                // get next Record available in file
                if (rbProfessor.Checked)
                {
                    Professor professor =
                       (Professor)reader.Deserialize(arquivo);
                    Console.WriteLine(professor.getNome());
                    // armazena valores de Registro num array de string 
                    txtNome.Text = professor.getNome().ToString();
                    txtIdade.Text = professor.getIdade().ToString();
                    txtEnd.Text = professor.getFormacao().ToString();
                    txtCursoFormacao.Text = professor.getEndereco().ToString();
                }
                else
                {
                    Aluno aluno =
                       (Aluno)reader.Deserialize(arquivo);

                    Console.WriteLine(aluno.getNome());
                    // armazena valores de Registro num array de string 
                    txtNome.Text = aluno.getNome();
                    txtIdade.Text = aluno.getIdade().ToString();
                    txtEnd.Text = aluno.getCurso();
                    txtCursoFormacao.Text = aluno.getEndereco();
                }
            }

            // trata excecção, quando não existe Registro no arquivo
            catch (SerializationException)
            {
                // fecha FileStream se não houver Registro no arquivo
                arquivo.Close();

                // notifica o usuário se não existe Registro em arquivo
                MessageBox.Show("Não existem mais registros no arquivo", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            arquivo.Close();
            btnGravarArquivo.Enabled = false;
            btnAbrirArquivo.Enabled = true;
            btnFechar.Enabled = false;
            btnLerArquivo.Enabled = false;
            btnCriarArquivo.Enabled = true;

            txtNome.Text = "";
            txtIdade.Text = "";
            txtEnd.Text = "";
            txtCursoFormacao.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // cria caixa de diálogo para usuário abrir arquivo
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            string fileName; // nome do arquivo contendo os dado

            // obtém o nome do arquivo para leitura
            fileName = fileChooser.FileName;
            // mostra erro se o usuário digitou arquivo inválido
            if (fileName == "" || fileName == null)
                MessageBox.Show("Nome de arquivo inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // cria FileStream para obter acesso de leitura ao arquivo 
                arquivo = new FileStream(fileName, FileMode.Open,
                   FileAccess.Read);

                listProfessor.Clear();
                listAluno.Clear();
                txtRelatorio.Clear();

                while (true)
                {
                    try
                    {

                        if (rbAlunoRel.Checked == true)
                        {
                            Aluno aluno =
                           (Aluno)reader.Deserialize(arquivo);

                            listAluno.Add(aluno);
                        }
                        else
                        {
                            Professor professor =
                            (Professor)reader.Deserialize(arquivo);

                            listProfessor.Add(professor);
                        }
                    }
                    // trata excecção, quando não existe Registro no arquivo
                    catch (SerializationException)
                    {
                        // fecha FileStream se não houver Registro no arquivo
                        arquivo.Close();
                        break;
                    }
                }
                
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rbAlunoRel.Checked==true)
            {
                for (int i = 0; i < listAluno.Count; i++)
                {
                    txtRelatorio.AppendText("Nome: " + listAluno[i].getNome().ToString() + "\n");
                    txtRelatorio.AppendText("Endereço: " + listAluno[i].getEndereco().ToString() + "\n");
                    txtRelatorio.AppendText("Idade:: " + listAluno[i].getIdade().ToString() + "\n");
                    txtRelatorio.AppendText("Curso: " + listAluno[i].getCurso().ToString() + "\n");
                    txtRelatorio.AppendText("\n");
                }
            }
            else
            {
                for (int i = 0; i < listProfessor.Count; i++)
                {
                    txtRelatorio.AppendText("Nome: " + listProfessor[i].getNome().ToString() + "\n");
                    txtRelatorio.AppendText("Endereço: " + listProfessor[i].getEndereco().ToString() + "\n");
                    txtRelatorio.AppendText("Idade:: " + listProfessor[i].getIdade().ToString() + "\n");
                    txtRelatorio.AppendText("Formação: " + listProfessor[i].getFormacao().ToString() + "\n");
                    txtRelatorio.AppendText("\n");
                }
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;
        }
    }
}
