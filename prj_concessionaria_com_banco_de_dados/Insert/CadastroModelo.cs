using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados.Insert
{
	class CadastroModelo
    {
        private MySqlConnection conexao;

		private MySqlCommand comando;

        public void CadastraModelo(ModeloModelo modelo)
        {
            try
            {
                conexao = new MySqlConnection(Conexao.conector());

                conexao.Open();

                comando = new MySqlCommand("pInserirModelo", conexao);

				comando.CommandType = CommandType.StoredProcedure;

				comando.Parameters.AddWithValue("modelo", modelo.Modelo);
				comando.Parameters.AddWithValue("fk_marca", modelo.Marca);

				MySqlParameter my = comando.Parameters.AddWithValue("codModelo", SqlDbType.Int);
				my.Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();

                conexao.Close();
            }
            catch(Exception ex)
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
