using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;

namespace prj_concessionaria_com_banco_de_dados
{
    class Atualizar
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;

		string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

		public void AtualizaVeiculo(ModeloVeiculo modeloVeiculo)
        {
            try
            {
                conexao = new MySqlConnection(caminhoBanco);

                conexao.Open();

                string atualizar = "UPDATE tbveiculo SET " +
                    "fk_modelo='"+modeloVeiculo.Modelo+"', " +
                    "fk_cor='"+modeloVeiculo.Cor+"', " +
                    "ano='"+modeloVeiculo.Ano+"', " +
                    "ano_modelo='"+modeloVeiculo.AnoModelo+"', " +
                    "fk_cambio='"+modeloVeiculo.Cambio+"', " +
                    "fk_combustivel='"+modeloVeiculo.Combustivel+"', " +
                    "kmRodado='"+modeloVeiculo.KmRodado+"', " +
                    "fk_categoria='"+modeloVeiculo.Categoria+"', " +
                    "fk_segmento='"+modeloVeiculo.Segmento+"', " +
                    "qtdPortas='"+modeloVeiculo.Porta+"', " +
                    "obsVeiculo='"+modeloVeiculo.Obs+"' " +
                    "WHERE placa='"+modeloVeiculo.Placa+"'";

                comando = new MySqlCommand(atualizar, conexao);

                comando.ExecuteNonQuery();

                conexao.Close();

            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível salvar as alterações." + e);
            }
        }

		public void AtualizaFuncionario(ModeloFuncionario modeloFuncionario)
		{
			try
			{
				conexao = new MySqlConnection(caminhoBanco);

				conexao.Open();

				string atualizar = "UPDATE tbfuncionario SET Nome='" + modeloFuncionario.Nome + "', " +
					"FK_Cargo='" + modeloFuncionario.Cargo + "', Email='" + modeloFuncionario.Email + "'" +
					" WHERE codFuncionario = '" + modeloFuncionario.CodFuncionario + "'";

				comando = new MySqlCommand(atualizar, conexao);

				comando.ExecuteNonQuery();

				conexao.Close();
			}
			catch (Exception e)
			{
				throw new Exception("Erro ao atualizar cadastro: " + e.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

	}
}
