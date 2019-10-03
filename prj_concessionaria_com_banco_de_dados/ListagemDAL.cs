using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace prj_concessionaria_com_banco_de_dados
{
    class ListagemDAL
    {
        string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

        MySqlConnection conexao;
        MySqlCommand comando;

        public DataTable ListagemVeiculos()
        {
            try
            {
                conexao = new MySqlConnection(caminhoBanco);

                conexao.Open();

                string selecionar = "SELECT " +
                    "M.modelo, CO.cor, CA.cambio, COM.combustivel, CAT.categoria, S.segmento, V.obsVeiculo " +
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
        }

    }
}
