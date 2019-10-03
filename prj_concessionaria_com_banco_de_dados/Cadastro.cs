using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A linha abaixo permite o uso de um banco de dados MySQL
using MySql.Data.MySqlClient;

namespace prj_concessionaria_com_banco_de_dados
{
    class Cadastro
    {
        //A linha abaixo faz referência a uma conexão com o banco
        private MySqlConnection conexao;

        public void CadastraVeiculo(ModeloVeiculo modeloVeiculo)
        {
            //A linha abaixo grava o caminho do banco
            string caminhoBanco = "SERVER=localhost;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            try
            {
                //A linha abaixo faz uma conexão com o banco de dados pedido
                conexao = new MySqlConnection(caminhoBanco);

                //A linha abaixo abre o banco permitindo inserir dados nele
                conexao.Open();

                //A linha abaixo é o comando INSERT do SQL recebendo as propriedades da classe modeloVeiculo
                string inserir = "INSERT INTO tbveiculo(placa, fk_modelo, fk_cor, ano, ano_modelo, fk_cambio, fk_combustivel, kmRodado, fk_categoria, fk_segmento, qtdPortas, obsVeiculo)VALUES(" +
                    "'" + modeloVeiculo.Placa + "', '" + modeloVeiculo.Modelo + "', '" + modeloVeiculo.Cor + "', '" + modeloVeiculo.Ano + "', '" + modeloVeiculo.AnoModelo + "', '" + modeloVeiculo.Cambio + "', "+
                    "'" + modeloVeiculo.Combustivel + "', '" + modeloVeiculo.KmRodado + "', '" + modeloVeiculo.Categoria + "', '" + modeloVeiculo.Segmento + "', '" + modeloVeiculo.Porta + "', '" + modeloVeiculo.Obs + "')";

                //A linha abaixo roda os comandos SQL
                MySqlCommand comando = new MySqlCommand(inserir, conexao);

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

        //public void CadastraMarca(ModeloMarca modeloMarca)
    }
}
