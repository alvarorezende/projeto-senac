using MySql.Data.MySqlClient;
using prj_concessionaria_com_banco_de_dados.Insert;
using prj_concessionaria_com_banco_de_dados.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace prj_concessionaria_com_banco_de_dados
{
	public partial class tlCadModelo : Form



    {
        public tlCadModelo()
        {
            InitializeComponent();

            ListaMarca();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadModelo_Click(object sender, EventArgs e)
        {
            ModeloModelo modelo = new ModeloModelo();
            CadastroModelo cadastroModelo = new CadastroModelo();

            try
            {
                modelo.Modelo = txtModelo.Text;
                modelo.Marca = Convert.ToInt32(cbMarca.SelectedValue);

                cadastroModelo.CadastraModelo(modelo);

                MessageBox.Show("Modelo cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtModelo.Clear();

                txtModelo.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor informado inválido", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaMarca()
        {
            MySqlConnection conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            MySqlCommand comando = new MySqlCommand("selectmarca", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            DataTable marcasSelecionadas = new DataTable();

            marcasSelecionadas.Load(comando.ExecuteReader());

            cbMarca.DisplayMember = "marca";

            cbMarca.ValueMember = "codMarca";

            cbMarca.DataSource = marcasSelecionadas;

            cbMarca.SelectedIndex = -1;

            conexao.Close();
        }
    }
}
