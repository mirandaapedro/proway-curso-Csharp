using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class ProdutoCadastroSimplificadoBancoDadosForm : Form
    {
        public ProdutoCadastroSimplificadoBancoDadosForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text.Trim());
            var precoUnitario = Convert.ToDouble(textBoxPrecoUnitario.Text.Trim());

            var comando = Conectar();
            comando.CommandText = @"INSERT INTO 
        produtos (nome, preco_unitario, quantidade) 
        VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

            comando.ExecuteNonQuery();
            MessageBox.Show("Produto cadastrado com sucesso!");
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            var comando = Conectar();
            comando.CommandText = "SELECT * FROM produtos";

            // Tabela em memória para ler os dados da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar conexão com o banco de dados
            comando.Connection.Close();

            // Remover todas as linhas do DataGridView
            dataGridView1.Rows.Clear();

            // Percorrer a tabela em memória (registros dos produtos)
            for (int i=0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                dataGridView1.Rows.Add(new object[] {
                    linha["ID"],  
                    linha["nome"],
                    linha["quantidade"],
                    linha["preco_unitario"]
                });
            }
        }


        private SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\73290\source\repos\proway-curso-c-sharp-lc1-2023-04\WindowsFormsExemplos\BancoDados\WindowsFormsBancoDados.mdf;Integrated Security=True";
            conexao.Open();

            var comando = conexao.CreateCommand();

            return comando;
        }

        private void ProdutoCadastroSimplificadoBancoDadosForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var comando = Conectar();
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";

            var LinhaSelecionada = dataGridView1.SelectedRows[0];
            var id = LinhaSelecionada.Cells[0].Value;
            comando.Parameters.AddWithValue("@ID", id);
        }
    }
}
