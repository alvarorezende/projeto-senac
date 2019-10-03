using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_concessionaria_com_banco_de_dados.Modelo;

//login: teste
//senha: teste

namespace prj_concessionaria_com_banco_de_dados
{
	public partial class tlLogin : Form
	{
		ModeloFuncionario modeloFuncionario = new ModeloFuncionario();

		public tlLogin()
		{
			InitializeComponent();
		}

		private void btnentrar_Click(object sender, EventArgs e)
		{
			string email = txtlogin.Text;
			string senha = txtsenha.Text;

			modeloFuncionario.Email = txtlogin.Text;

			MySqlConnection conexao = new MySqlConnection(Conexao.conector());

			MySqlCommand comando = new MySqlCommand("plogin", conexao);

			comando.CommandType = CommandType.StoredProcedure;

			comando.Parameters.AddWithValue("email", txtlogin.Text);
			comando.Parameters.AddWithValue("senha", txtsenha.Text);

			conexao.Open();

			int i = Convert.ToInt32(comando.ExecuteScalar());

			if (i > 0)
			{
				tlHome tlhome = new tlHome();
				this.Visible = false;
				tlhome.ShowDialog();
			}
			else
			{
				MessageBox.Show("E-mail ou senha incorreto!");
			}

			conexao.Close();
		}

		private void btncancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

