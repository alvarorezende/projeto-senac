using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados
{
    class ModeloVeiculo
    {
        private string mPlaca;
        private int mModelo;
        private int mCor;
        private int mAno;
        private int mAnoModelo;
        private string mCambio;
        private string mCombustivel;
        private int mKmRodado;
        private string mCategoria;
        private string mSegmento;
        private int mPorta;
        private string mObs;

        public string Placa
        {
            get { return this.mPlaca; }
            set { this.mPlaca = value; }
        }
        public int Modelo
        {
            get { return this.mModelo; }
            set { this.mModelo = value; }
        }
        public int Cor
        {
            get { return this.mCor; }
            set { this.mCor = value; }
        }
        public int Ano
        {
            get { return this.mAno; }
            set { this.mAno = value; }
        }
        public int AnoModelo
        {
            get { return this.mAnoModelo; }
            set { this.mAnoModelo = value; }
        }
        public string Cambio
        {
            get { return this.mCambio; }
            set { this.mCambio = value; }
        }
        public string Combustivel
        {
            get { return this.mCombustivel; }
            set { this.mCombustivel = value; }
        }
        public int KmRodado
        {
            get { return this.mKmRodado; }
            set { this.mKmRodado = value; }
        }
        public string Categoria
        {
            get { return this.mCategoria; }
            set { this.mCategoria = value; }
        }
        public string Segmento
        {
            get { return this.mSegmento; }
            set { this.mSegmento = value; }
        }
        public int Porta
        {
            get { return this.mPorta; }
            set { this.mPorta = value; }
        }
        public string Obs
        {
            get { return this.mObs; }
            set { this.mObs = value; }
        }
    }
}
