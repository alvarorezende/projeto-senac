using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;

namespace prj_concessionaria_com_banco_de_dados
{
    class Excluir
    {
        MySqlConnection conexao;
        MySqlCommand comando;

		public void ExcluirVeiculo(ModeloVeiculo modeloVeiculo)
        {
            try
            {
                conexao = new MySqlConnection(Conexao.conector());

                conexao.Open();

                string excluir = "DELETE FROM tbveiculo WHERE placa = '" + modeloVeiculo.Placa + "'";

                comando = new MySqlCommand(excluir, conexao);

                comando.ExecuteNonQuery();

                conexao.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível excluir o veículo desejado." + e);
            }
            finally
            {
                conexao.Close();
            }
        }

		public void ExcluirFuncionario(ModeloFuncionario modeloFuncionario)
		{
			try
			{
				conexao = new MySqlConnection(Conexao.conector());

				conexao.Open();

				string excluirFuncionario = "DELETE FROM tbfuncionario WHERE codFuncionario = '" + modeloFuncionario.CodFuncionario + "'";

				comando = new MySqlCommand(excluirFuncionario, conexao);

				comando.ExecuteNonQuery();

				conexao.Close();

			}
			catch (Exception e)
			{
				throw new Exception("Erro ao excluir funcionário" + e.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
	}
}
