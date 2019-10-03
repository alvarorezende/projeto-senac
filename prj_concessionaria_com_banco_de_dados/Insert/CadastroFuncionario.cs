using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados.Insert
{
	class CadastroFuncionario
	{
		private MySqlConnection conexao;

		private MySqlCommand comando;

		public void CadastrarFuncionario(ModeloFuncionario modeloFuncionario)
		{
		
			try
			{
				conexao = new MySqlConnection(Conexao.conector());

				conexao.Open();

				comando = new MySqlCommand("pInserirFuncionario", conexao);

				comando.CommandType = CommandType.StoredProcedure;

				comando.Parameters.AddWithValue("nome", modeloFuncionario.Nome);
				comando.Parameters.AddWithValue("fk_cargo", modeloFuncionario.Cargo);
				comando.Parameters.AddWithValue("email", modeloFuncionario.Email);
				comando.Parameters.AddWithValue("senha", modeloFuncionario.Senha);

				MySqlParameter my = comando.Parameters.AddWithValue("codFuncionario", SqlDbType.Int);
				my.Direction = ParameterDirection.Output;

				comando.ExecuteNonQuery();

				conexao.Close();

			}
			catch (Exception e)
			{
				throw new Exception("Erro ao cadastrar funcionário" + e.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
	}
}
