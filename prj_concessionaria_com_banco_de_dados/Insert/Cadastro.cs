//A linha abaixo permite o uso de um banco de dados MySQL
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
	class Cadastro
    {
        //A linha abaixo faz referência a uma conexão com o banco
        private MySqlConnection conexao;

		private MySqlCommand comando;

        public void CadastraVeiculo(ModeloVeiculo modeloVeiculo)
        {
			//A linha abaixo grava o caminho do banco
            try
            {
                //A linha abaixo faz uma conexão com o banco de dados pedido
                conexao = new MySqlConnection(Conexao.conector());

                //A linha abaixo abre o banco permitindo inserir dados nele
                conexao.Open();
               
                comando = new MySqlCommand("pInserirVeiculo", conexao);

				comando.CommandType = CommandType.StoredProcedure;

				comando.Parameters.AddWithValue("placa", modeloVeiculo.Placa);
				comando.Parameters.AddWithValue("fk_modelo", modeloVeiculo.Modelo);
				comando.Parameters.AddWithValue("fk_cor", modeloVeiculo.Cor);
				comando.Parameters.AddWithValue("ano", modeloVeiculo.Ano);
				comando.Parameters.AddWithValue("ano_modelo", modeloVeiculo.AnoModelo);
				comando.Parameters.AddWithValue("fk_cambio", modeloVeiculo.Cambio);
				comando.Parameters.AddWithValue("fk_combustivel", modeloVeiculo.Combustivel);
				comando.Parameters.AddWithValue("kmRodado", modeloVeiculo.KmRodado);
				comando.Parameters.AddWithValue("fk_categoria", modeloVeiculo.Categoria);
				comando.Parameters.AddWithValue("fk_segmento", modeloVeiculo.Segmento);
				comando.Parameters.AddWithValue("qtdPortas", modeloVeiculo.Porta);
				comando.Parameters.AddWithValue("obsVeiculo", modeloVeiculo.Obs);

				//A linha abaixo grava no banco de dados
				comando.ExecuteNonQuery();

                //A linha abaixo fecha o banco, ela é super obrigatória
                conexao.Close();
                    
             }
            catch (Exception ex)
            {
                throw new Exception("Erro de Banco" + ex);
            }
            finally
            {
                //A estrutura FINALLY obriga o sistema fechar o banco em caso de erros
                conexao.Close();
            }           
        }
    }
}
