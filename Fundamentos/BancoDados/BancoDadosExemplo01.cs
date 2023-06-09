﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.BancoDados
{
    internal class BancoDadosExemplo01
    {

        private const string CadeiaConexaoBancoDados = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\73290\Desktop\BANCODADOS.MDF; Integrated Security = True; Connect Timeout = 30";

        public void Executar()
        {
            /* CRUD
             * Create: INSSERT INTO nome_tabela (colunas) VALUES (valores)
             * Read: SELECT colunas FROM nome_tabela
             * Update: UPDATE nome_tabela SET nome_coluna = valor_coluna WHERE id = id_desejado;
             * Delete: DELETE FROM nome_tabela WHERE id= id_desejado;
             */
            //CriarRegistro();
            //ApagarRegistro();
            //AtualizarRegistro();
            ConsultarRegistros();
        }

        private void ConsultarRegistros()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, categoria FROM jogos";

            // CRIAR UMA TABELA EM MEMÓRIA PARA ARMAZENAR OS DADOS DA CONSULTA
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var id = Convert.ToInt32(linha["id"]);
                var nome = linha["nome"].ToString();
                var categoria = linha["categoria"].ToString();
                Console.WriteLine(
                    $"Id: {id} Nome: {nome} Categoria: {categoria}");
            }
        }

        private void AtualizarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE jogos SET nome = 'God Of War 1', categoria = 'RPG' WHERE id = 12";
            comando.ExecuteNonQuery();
        }

        private void ApagarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM jogos WHERE id IN ('02', '03', '04')";
            comando.ExecuteNonQuery();
        }

        private static void CriarRegistro()
        {
            var conexao = new SqlConnection();

            // ConnectionString nada mais é do que o caminho do banco, assim como,
            // caso necessário login, senha entre outros.
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();
            Console.WriteLine("Conectou!");

            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO jogos (nome, categoria) VALUES ('God of War', 'RPG')";
            comando.ExecuteNonQuery();

            Console.WriteLine("Registro criado com sucesso");
        }
    }
}
