using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
	class ListagemDAL
    {
        MySqlConnection conexao;
        MySqlCommand comando;

        public DataTable ListagemVeiculos()
        {
            try
            {
                conexao = new MySqlConnection(Conexao.conector());

                conexao.Open();

                string selecionar = "SELECT " +
                    "V.placa, M.modelo, CO.cor, V.ano, V.ano_modelo, V.kmRodado, V.qtdPortas, CA.cambio, COM.combustivel, CAT.categoria, S.segmento, V.obsVeiculo " +
                    "FROM tbveiculo V, tbcor CO, tbmodelo M, tbcambio CA, tbcombustivel COM, tbcategoria CAT, tbsegmento S " +
                    "WHERE  V.fk_modelo = M.codModelo AND V.fk_cor = CO.codCor AND V.fk_cambio = CA.codCambio " +
                    "AND V.fk_combustivel = COM.codCombustivel AND V.fk_categoria = CAT.codCategoria AND V.fk_segmento = S.codSegmento";

                comando = new MySqlCommand(selecionar, conexao);

                //A linha abaxo refencia as informações ao ID
                MySqlDataAdapter DAVeiculos = new MySqlDataAdapter();

                DAVeiculos.SelectCommand = comando;

               //A linha abaixo executa a ação
                DataTable DTVeiculos = new DataTable();

                //A linha anaixo trás as informações pré montadas, ou seja, atrela a linha tods com uma só informação
                DAVeiculos.Fill(DTVeiculos);

                return DTVeiculos;

            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível carregar seus dados." + e);
            }
			finally
			{
				conexao.Close();
			}
        }

		public DataTable ListarCargo()
		{
			try
			{
				conexao = new MySqlConnection(Conexao.conector());

				conexao.Open();

				string selecionar = "SELECT F.codFuncionario, F.nome, C.cargo, F.email " +
					"FROM tbfuncionario F, tbcargo C " +
					"WHERE F.fk_cargo = C.codCargo";

				comando = new MySqlCommand(selecionar, conexao);

				MySqlDataAdapter DAFuncionarios = new MySqlDataAdapter();

				DAFuncionarios.SelectCommand = comando;

				DataTable DTFuncionarios = new DataTable();

				DAFuncionarios.Fill(DTFuncionarios);

				return DTFuncionarios;
			}
			catch (Exception e)
			{
				throw new Exception("Não foi possível carregar seus dados." + e.Message);
			}
			finally
			{
				conexao.Close();
			}
		}
	}
}
