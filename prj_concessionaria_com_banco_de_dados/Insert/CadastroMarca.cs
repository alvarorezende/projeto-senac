using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados.Insert
{
	class CadastroMarca
    {
        private MySqlConnection conexao;

		private MySqlCommand comando;

        public void CadastraMarca(ModeloMarca modeloMarca)
        {
 
            try
            {
                conexao = new MySqlConnection(Conexao.conector());

                conexao.Open();

                comando = new MySqlCommand("pInserirMarca", conexao);

				comando.CommandType = CommandType.StoredProcedure;

				comando.Parameters.AddWithValue("marca", modeloMarca.Marca);

				MySqlParameter my = comando.Parameters.AddWithValue("codMarca", SqlDbType.Int);
				my.Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de banco" + ex);
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
