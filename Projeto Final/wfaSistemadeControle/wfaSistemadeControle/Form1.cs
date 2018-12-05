using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Drawing.Imaging;

namespace wfaSistemadeControle
{
    public partial class frmPrincipal : Form
    {
        private NpgsqlConnection conn; //Estabelecer conexao
        private NpgsqlCommand command; //Define comandos
        private NpgsqlDataReader result; //Guarda 

        private string cod_image_cardapio = "3";

        MemoryStream ms;
        byte[] photo_aray;

        private List<object> list_cod_cardapio = new List<object>();
       

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {

        }

        private void connectionTest()
        {
            //Criar e definir os parametros de conexao
            try
            {
                //33Mm2907
                conn = new NpgsqlConnection("Server=127.0.0.1; User Id=postgres; Password=1234; Database=SistemadeControle");

                //Abrindo conexao
                conn.Open();
                //MessageBox.Show("Conexão realizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informação de Erro: " + ex);
            }
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            connectionTest();
        }

        private void btnadicionarCardapio_Click(object sender, EventArgs e)
        {
            //Conectando ao banco
            connectionTest();

            try
            {
                //Definindo o comando para inserir
                command = new NpgsqlCommand("INSERT INTO cardapio (nome_cardapio, preco_venda, cod_image) VALUES ('"
                    + txtNomeProd.Text + "'," + txtPreco.Text + "," + cod_image_cardapio  + ");", conn);


                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Cardápio cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpando os campos aposa inclusao
                txtNomeProd.Text = "";
                txtPreco.Text = "";

                //Fechando a conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informação de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SelectRecords();
        }

        private void SelectRecords()
        {
            //Conectando ao banco
            connectionTest();

            //Limpandos todas as linhas do dataGrid
            dgCardapio.Rows.Clear();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("SELECT cod_cardapio, nome_cardapio, preco_venda, cod_image FROM cardapio order by cod_cardapio", conn);

                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no dataGrid
                    dgCardapio.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2), result.GetValue(3)});
                }

                //Fechando a conexao
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            connectionTest();

            try
            {
                //Definindo o comando para atualização
                command = new NpgsqlCommand("UPDATE cardapio SET nome_cardapio = '"
                    + txtNomeProd.Text + "', preco_venda = "
                    + txtPreco.Text + " WHERE cod_cardapio = "
                    + dgCardapio.CurrentRow.Cells[0].Value, conn);

                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Registro atualizado com sucesso!");

                //Chama o select
                SelectRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void dgCardapio_DoubleClick(object sender, EventArgs e)
        {
            if (dgCardapio.Rows.Count != 0)
            {
                txtNomeProd.Text = dgCardapio.CurrentRow.Cells[1].Value.ToString();
                txtPreco.Text = dgCardapio.CurrentRow.Cells[2].Value.ToString();

                connectionTest();

                command = new NpgsqlCommand("select img from image where cod_image = " + dgCardapio.CurrentRow.Cells[3].Value.ToString(), conn);
                result = command.ExecuteReader();

                result.Read();
                photo_aray = (byte[])result.GetValue(0);
                ms = new MemoryStream(photo_aray);
                imagemCardapio.Image = Image.FromStream(ms);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Conectar ao banco
            connectionTest();

            try
            {

                //Definindo o comando para exclusão do registro
                command = new NpgsqlCommand("DELETE FROM cardapio WHERE cod_cardapio = "
                    + dgCardapio.CurrentRow.Cells[0].Value + " and nome_cardapio = '" + dgCardapio.CurrentRow.Cells[1].Value + "'", conn);


                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso!");

                //Chama o select
                SelectRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            //Conectando ao banco
            connectionTest();

            try
            {
                //Definindo o comando para inserir
                command = new NpgsqlCommand("INSERT INTO produto (nome_produto, custo_unidade, unidade_compra, " +
                    "qtd_compra, metrica) VALUES ('"
                    + txtProduto.Text + "'," + txtCustoProd.Text + ", '" + cbUnidadeCompra.SelectedItem + "'" +
                    ", " + txtQtdCompra.Text + ", '" + cbMetrica.SelectedItem + "');", conn);


                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Produto cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpando os campos aposa inclusao
                txtProduto.Text = "";
                txtCustoProd.Text = "";
                txtQtdCompra.Text = "";
                cbMetrica.SelectedIndex = -1;
                cbUnidadeCompra.SelectedIndex = -1;

                //Fechando a conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informação de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbReceita_Click(object sender, EventArgs e)
        {
            list_cod_cardapio.Clear();

            //Conectando ao banco
            connectionTest();
            cbItensCardapio.Items.Clear();
            dgProdutosReceita.Rows.Clear();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("SELECT cod_cardapio, nome_cardapio FROM cardapio order by nome_cardapio", conn);

                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no combobox
                    cbItensCardapio.Items.Add(result.GetValue(1));
                    list_cod_cardapio.Add(result.GetValue(0));
                }

                conn.Close();
                connectionTest();

                command = new NpgsqlCommand("SELECT cod_produto, nome_produto FROM produto order by cod_produto", conn);

                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no dataGrid
                    dgProdutosReceita.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1)});

                }

                //Fechando a conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }

        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
         
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            if ((dgProdutosReceita.Rows.Count > 0) && (dgProdutosReceita.SelectedRows.Count >= 0))
                dgReceitaFinal.Rows.Add(list_cod_cardapio[cbItensCardapio.SelectedIndex], dgProdutosReceita.CurrentRow.Cells[0].Value, 0);
                
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirReceita_Click(object sender, EventArgs e)
        {
            dgReceitaFinal.Rows.RemoveAt(dgReceitaFinal.CurrentCell.RowIndex);
        }

        private void cbItensCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dgReceitaFinal.Rows.Clear();
            connectionTest();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("SELECT cod_cardapio, cod_produto, qtd_utilizada FROM receita where cod_cardapio = " + list_cod_cardapio[cbItensCardapio.SelectedIndex] +
                    " order by cod_cardapio, cod_produto", conn);

                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no combobox
                    dgReceitaFinal.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2) });
                }

                //Fechando a conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }

        }

        private void btnGravarReceita_Click(object sender, EventArgs e)
        {
            connectionTest();


            try
            {
                command = new NpgsqlCommand("delete from receita where cod_cardapio = "
                       + list_cod_cardapio[cbItensCardapio.SelectedIndex], conn);

                command.ExecuteReader();


                for (int i = 0; i < dgReceitaFinal.Rows.Count -1; i++)
                {
                    conn.Close();
                    connectionTest();
                    //Definindo o comando para inserir
                    
                    command = new NpgsqlCommand("INSERT INTO receita (cod_cardapio, cod_produto, qtd_utilizada) VALUES ("
                        + dgReceitaFinal.Rows[i].Cells[0].Value + "," + dgReceitaFinal.Rows[i].Cells[1].Value + "" +
                        ", " + dgReceitaFinal.Rows[i].Cells[2].Value + ");", conn);


                    //Executando o comando
                    command.ExecuteReader();
                }

                MessageBox.Show("Receita cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpando os campos aposa inclusao

                cbItensCardapio.ResetText();
                dgReceitaFinal.Rows.Clear();

                //Fechando a conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informação de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgReceitaFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbVendasCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbVendas_Click(object sender, EventArgs e)
        {
            list_cod_cardapio.Clear();
            //Conectando ao banco
            connectionTest();
            cbVendasCardapio.Items.Clear();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("SELECT cod_cardapio, nome_cardapio FROM cardapio order by nome_cardapio", conn);

                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no combobox
                    cbVendasCardapio.Items.Add(result.GetValue(1));
                    list_cod_cardapio.Add(result.GetValue(0));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnInserirVenda_Click(object sender, EventArgs e)
        {
            connectionTest();


            try
            {
                

                    //Definindo o comando para inserir

                    command = new NpgsqlCommand("INSERT INTO vendas VALUES ('"+ 
                        datePicker.Value + "'," + list_cod_cardapio[cbVendasCardapio.SelectedIndex] + "" +
                        ", " + txtQtdVendida.Text + ");", conn);


                    //Executando o comando
                    command.ExecuteReader();

                MessageBox.Show("Venda cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpando os campos aposa inclusao

                cbVendasCardapio.ResetText();

                //Fechando a conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informação de Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            //Conectando ao banco
            connectionTest();

            //Limpandos todas as linhas do dataGrid
            dgVendas.Rows.Clear();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("select v.data_venda, v.cod_cardapio, p.nome_cardapio, sum(v.qtd) as qtd " +
                "from vendas v, cardapio p where v.cod_cardapio = p.cod_cardapio and data_venda = '" +
                datePicker.Value + "' group by v.data_venda, v.cod_cardapio, p.nome_cardapio " +
                "order by v.data_venda, v.cod_cardapio", conn);
                
                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no dataGrid
                    dgVendas.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2), result.GetValue(3) });
                }

                //Fechando a conexao
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnEditarVendas_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirVendas_Click(object sender, EventArgs e)
        {
            connectionTest();

            try
            {

                //Definindo o comando para exclusão do registro
                command = new NpgsqlCommand("DELETE FROM vendas WHERE data_venda =  '" +
                datePicker.Value + "' and cod_cardapio = '" + dgVendas.CurrentRow.Cells[1].Value + "'", conn);


                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnConsultarTodas_Click(object sender, EventArgs e)
        {
            connectionTest();

            //Limpandos todas as linhas do dataGrid
            dgVendas.Rows.Clear();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("select v.data_venda, v.cod_cardapio, p.nome_cardapio, sum(v.qtd) as qtd " +
                "from vendas v, cardapio p where v.cod_cardapio = p.cod_cardapio group by v.data_venda, v.cod_cardapio, p.nome_cardapio " +
                "order by v.data_venda, v.cod_cardapio", conn);

                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no dataGrid
                    dgVendas.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2), result.GetValue(3) });
                }

                //Fechando a conexao
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            //Conectando ao banco
            connectionTest();

            //Limpandos todas as linhas do dataGrid
            dgProdutos.Rows.Clear();

            try
            {
                //Definindo o comando a ser executado
                command = new NpgsqlCommand("SELECT * FROM produto order by nome_produto", conn);

                //Executando o comando e guardando o retorno em result 
                result = command.ExecuteReader();

                //Atualizar os dados encontrados no dataGrid
                while (result.Read()) //Estrutura de repetição para percorer todos os registros
                {
                    //Adicionar os registross no dataGrid
                    dgProdutos.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2), result.GetValue(3), result.GetValue(4), result.GetValue(5) });
                }

                //Fechando a conexao
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            connectionTest();

            try
            {
                //Definindo o comando para atualização
                command = new NpgsqlCommand("UPDATE produto SET custo_unidade = "
                    + dgProdutos.CurrentRow.Cells[2].Value + ", qtd_compra = "
                    + dgProdutos.CurrentRow.Cells[4].Value + " WHERE cod_produto = "
                    + dgProdutos.CurrentRow.Cells[0].Value, conn);

                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Registro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Chama o select
                SelectRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            connectionTest();

            try
            {

                //Definindo o comando para exclusão do registro
                command = new NpgsqlCommand("DELETE FROM produto WHERE cod_produto = " + dgProdutos.CurrentRow.Cells[0].Value, conn);


                //Executando o comando
                command.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();

            Console.WriteLine(fileChooser.FileName);

            imagemCardapio.Image = Image.FromFile(fileChooser.FileName);

            inserirImagem();
        }

        // Save the path Of Pic in database
        
        private void inserirImagem()
        {
            connectionTest();

            command = new NpgsqlCommand("insert into image(img) values (@photo)", conn);
            conv_photo();

            //Executando o comando
            command.ExecuteReader();
            MessageBox.Show("Imagem adicionada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            connectionTest();
            command = new NpgsqlCommand("select max(cod_image) from image", conn);
            result = command.ExecuteReader();

            result.Read();
            cod_image_cardapio = result.GetValue(0).ToString();

        }

        private void conv_photo()
        {
            //converting photo to binary data
            if (imagemCardapio.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                imagemCardapio.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                command.Parameters.AddWithValue("@photo", photo_aray);
            }
        }
    }
}

