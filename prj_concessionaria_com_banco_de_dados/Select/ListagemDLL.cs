using System;
using System.Data;

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

		public DataTable ExibirCargo()
		{
			try
			{
				DataTable DTCargo = new DataTable();

				listaDAL = new ListagemDAL();

				DTCargo = listaDAL.ListarCargo();

				return DTCargo;
			}
			catch (Exception e)
			{
				throw new Exception("Não foi possivel exibir seus arquivos!" + e);
			}
		}

	}
}
