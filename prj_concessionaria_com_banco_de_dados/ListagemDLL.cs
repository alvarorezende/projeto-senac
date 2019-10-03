using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace prj_concessionaria_com_banco_de_dados
{
    class ListagemDLL
    {
        ListagemDAL listaDAL;

        public DataTable ExibirVeiculos()
        {
            try
            {

                DataTable DTVeiculos = new DataTable();

                listaDAL = new ListagemDAL();

                DTVeiculos = listaDAL.ListagemVeiculos();

                return DTVeiculos;

            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível exibir seus arquivos" + e);
            }
        }

    }
}
