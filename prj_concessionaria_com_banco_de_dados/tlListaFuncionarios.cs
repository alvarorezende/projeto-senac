using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace prj_concessionaria_com_banco_de_dados
{
	public partial class tlListaFuncionarios : Form
	{
		ListagemDLL listaDll;
		MySqlConnection conexao;
		MySqlCommand comando;
		MySqlDataAdapter adapter;
		DataTable tabela;
		ModeloFuncionario modeloFuncionario;

		public tlListaFuncionarios()
		{
			InitializeComponent();
		}

		private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow linha = this.dgvFuncionarios.Rows[e.RowIndex];

				txtCod.Text = linha.Cells["codFuncionario"].Value.ToString();
				txtNome.Text = linha.Cells["nome"].Value.ToString();
				txtEmail.Text = linha.Cells["email"].Value.ToString();
				cbCargo.Text = linha.Cells["cargo"].Value.ToString();
			}
		}

		public void CarregaFuncionario()
		{
			listaDll = new ListagemDLL();

			try
			{
				dgvFuncionarios.DataSource = listaDll.ExibirCargo();
			}
			catch (Exception e)
			{
				MessageBox.Show("Não foi possível carregar os funcionários" + e);
			}
		}

		public void PesquisarFuncionario(string valorPesquisado)
		{
			try
			{

				conexao = new MySqlConnection(Conexao.conector());
				conexao.Open();

				string pesquisa = "SELECT F.codFuncionario, F.nome, C.cargo, F.email " +
						"FROM tbfuncionario F, tbcargo C " +
						"WHERE CONCAT(F.codFuncionario, F.nome, C.cargo, F.email) LIKE '%" + valorPesquisado + "%' " +
						"AND F.fk_cargo = C.codCargo";

				comando = new MySqlCommand(pesquisa, conexao);

				adapter = new MySqlDataAdapter(comando);

				tabela = new DataTable();

				adapter.Fill(tabela);

				dgvFuncionarios.DataSource = tabela;

				conexao.Close();
			}
			catch (Exception e)
			{
				throw new Exception("Não foi possível concluir a busca: " + e.Message);
			}
			finally
			{
				conexao.Close();
			}
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			string valorPesquisa = txtPesquisar.Text.ToString();
			PesquisarFuncionario(valorPesquisa);
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			modeloFuncionario = new ModeloFuncionario();
			Atualizar atualizar = new Atualizar();

			modeloFuncionario.CodFuncionario = Convert.ToInt32(txtCod.Text);
			modeloFuncionario.Nome = txtNome.Text;
			modeloFuncionario.Cargo = Convert.ToInt32(cbCargo.SelectedValue);
			modeloFuncionario.Email = txtEmail.Text;

			atualizar.AtualizaFuncionario(modeloFuncionario);

			MessageBox.Show("Informações do funcionario foram atualizadas com sucesso!",
				"Dados Atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ListarCargos()
		{
			conexao = new MySqlConnection(Conexao.conector());

			conexao.Open();

			comando = new MySqlCommand("selectcargo", conexao);

			comando.ExecuteNonQuery();

			DataTable cargoSelecinados = new DataTable();

			cargoSelecinados.Load(comando.ExecuteReader());

			cbCargo.DisplayMember = "cargo";

			cbCargo.ValueMember = "codCargo";

			cbCargo.DataSource = cargoSelecinados;

			conexao.Close();

		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			modeloFuncionario = new ModeloFuncionario();

			Excluir excluir = new Excluir();

			modeloFuncionario.CodFuncionario = int.Parse(txtCod.Text);

			excluir.ExcluirFuncionario(modeloFuncionario);

			txtCod.Clear();
			txtNome.Clear();
			txtEmail.Clear();

			MessageBox.Show("Funcionário excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void txtCod_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
