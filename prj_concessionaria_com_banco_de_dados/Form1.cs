using prj_concessionaria_com_banco_de_dados.Tela.Ajuda;
using System;
using System.Windows.Forms;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlHome : Form
    {
        public tlHome()
        {
            InitializeComponent();
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            tlCadVeiculo cadVeiculo = new tlCadVeiculo();
            cadVeiculo.Show();
        }

        private void ltVeículosCadastrados_Click(object sender, EventArgs e)
        {
            tlListaVeiculos listV = new tlListaVeiculos();
            listV.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjudaHome ajuda = new AjudaHome();
            ajuda.Show();
        }

        private void btnCadMarca_Click(object sender, EventArgs e)
        {
            tlCadMarca cadMarca = new tlCadMarca();
            cadMarca.Show();
        }

        private void btnCadModelo_Click(object sender, EventArgs e)
        {
            tlCadModelo cadModelo = new tlCadModelo();
            cadModelo.Show();
        }

		private void btnCadFuncionario_Click(object sender, EventArgs e)
		{
			tlCadFuncionario funcionario = new tlCadFuncionario();
			funcionario.Show();
		}

		private void btnListaFuncionarios_Click(object sender, EventArgs e)
		{
			tlListaFuncionarios listaFuncionarios = new tlListaFuncionarios();
			listaFuncionarios.Show();
		}
	}
}
