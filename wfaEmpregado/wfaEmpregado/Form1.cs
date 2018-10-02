using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEmpregado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empregado> empregados = new List<Empregado>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rbHorista.Checked)
                MessageBox.Show("Horista selecionado", "Funcionando", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("CLT selecionado", "Funcionando", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

        }

        private void rbCLT_CheckedChanged(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            edthoras.Hide();
            edtvalor.Hide();
            label4.Show();
            edtsalario.Show();
        }

        private void rbHorista_CheckedChanged(object sender, EventArgs e)
        {
            label4.Hide();
            label5.Show();
            label6.Show();
            edthoras.Show();
            edtvalor.Show();
            edtsalario.Hide();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (rbCLT.Checked)
            {
                EmpregadoCLT empregadoCLT = new EmpregadoCLT(edtnome.Text, edtcpf.Text,
                    edtend.Text, Convert.ToDouble(edtsalario.Text));
                empregados.Add(empregadoCLT);
                MessageBox.Show("Cadastro CLT realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EmpregadoHorista empregadoHorista = new EmpregadoHorista(edtnome.Text, edtcpf.Text,
                    edtend.Text, Convert.ToInt32(edthoras.Text), Convert.ToDouble(edtvalor.Text));
                empregados.Add(empregadoHorista);
                MessageBox.Show("Cadastro horista realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rbCLT.Select();
        }

        private void edtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void edthoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
            
        }

        private void edtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            lbRelatorio.Items.Clear();
            lbRelatorio.Items.Add("Tipo | Nome\t\t|\tCPF\t|\tEndereço\t|\tSalário");
            lbRelatorio.Items.Add("-----------------------" +
                "--------------------------------------------------------------" +
                "-----------------------------------------------------------" +
                "----------------------------------------" +
                "---------------------------------------");
            for (int i=0; i<empregados.Count; i++)
            {
                lbRelatorio.Items.Add(empregados[i].imprime());  
            }
        }

        private void edtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox; // ou text Box
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                t.SelectionStart = t.Text.Length + 1;

                if (t.Text.Length == 3 || t.Text.Length == 7)
                    t.Text += ".";
                else if (t.Text.Length == 11)
                    t.Text += "-";
                t.SelectionStart = t.Text.Length + 1;
            }
        }

        private void edtcpf_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
