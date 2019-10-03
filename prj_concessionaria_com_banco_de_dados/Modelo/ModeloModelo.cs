using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados.Modelo
{
    class ModeloModelo
    {
        private int mCodModelo;
        private string mModelo;
        private int mMarca;

        public int CodModelo
        {
            get { return this.mCodModelo; }
        }

        public string Modelo
        {
            get { return this.mModelo; }
            set { this.mModelo = value; }
        }

        public int Marca
        {
            get { return this.mMarca; }
            set { this.mMarca = value; }
        }
    }
}
