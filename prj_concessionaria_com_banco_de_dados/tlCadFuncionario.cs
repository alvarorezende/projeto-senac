using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Insert;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace prj_concessionaria_com_banco_de_dados
{
	public partial class tlCadFuncionario : Form
	{
		public tlCadFuncionario()
		{
			InitializeComponent();

			ListarCargo();
		}

		MySqlConnection conexao;
		MySqlCommand comando;

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			ModeloFuncionario modeloFuncionario = new ModeloFuncionario();

			CadastroFuncionario cadastro = new CadastroFuncionario();

			if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
			{
				MessageBox.Show("Por favor, informar o nome do funcionário", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				txtNome.Focus();
			}
			else
			{
				modeloFuncionario.Nome = txtNome.Text;
				modeloFuncionario.Cargo = Convert.ToInt32(cbCargo.SelectedValue);
				modeloFuncionario.Email = txtEmail.Text;
				modeloFuncionario.Senha = txtSenha.Text;

				cadastro.CadastrarFuncionario(modeloFuncionario);

				MessageBox.Show("Funcionário cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

				txtNome.Clear();
				txtEmail.Clear();
				txtSenha.Clear();
			}
		}

		public void ListarCargo()
		{
			conexao = new MySqlConnection(Conexao.conector());

			conexao.Open();

			comando = new MySqlCommand("selectcargo", conexao);

			comando.CommandType = CommandType.StoredProcedure;

			comando.ExecuteNonQuery();

			//a linha abaixo cria uma tabela virtual
			DataTable selecionados = new DataTable();

			//a linha abaixo irá carregar cada linha individualmente
			selecionados.Load(comando.ExecuteReader());

			//a linha abaixo faz a referência da coluna que irá carregar a ser mostrada
			cbCargo.DisplayMember = "cargo";

			//a linha abaixo identifica o valor selecionado
			cbCargo.ValueMember = "codCargo";

			//a linha abaixo atribui as funções desejadas ao campo
			cbCargo.DataSource = selecionados;

			conexao.Close();

		}

		private void btncancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
