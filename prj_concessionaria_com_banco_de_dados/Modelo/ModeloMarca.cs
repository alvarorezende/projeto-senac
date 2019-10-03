using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados.Modelo
{
    class ModeloMarca
    {
        private int mCodMarca;
        private string mMarca;

        public int CodMarca
        {
            get { return this.mCodMarca; }
        }

        public string Marca
        {
            get { return this.mMarca; }
            set { this.mMarca = value; }
        }

    }
}
