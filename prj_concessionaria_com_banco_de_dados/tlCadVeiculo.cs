using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace prj_concessionaria_com_banco_de_dados
{
	public partial class tlCadVeiculo : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        public tlCadVeiculo()
        {
            InitializeComponent();

            ListaVeiculo();

            ListaCor();

            ListaCambio();

            ListaCombustivel();

            ListaCategoria();

            ListaSegmento();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {

            ModeloVeiculo modeloVeiculo = new ModeloVeiculo();
            Cadastro cadastro = new Cadastro();

            try
            {
                int qtdPortas = int.Parse(txtPortas.Text);

                if (string.IsNullOrEmpty(txtPlaca.Text))
                {
                    MessageBox.Show("A placa do veículo é obrigatória!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Focus();
                }
                else
                {
                    modeloVeiculo.Placa = txtPlaca.Text;
                    modeloVeiculo.Modelo = Convert.ToInt32(cbModelo.SelectedValue);
                    modeloVeiculo.Cor = Convert.ToInt32(cbCor.SelectedValue);
                    modeloVeiculo.Ano = int.Parse(txtAno.Text);
                    modeloVeiculo.AnoModelo = int.Parse(txtAnoModelo.Text);
                    modeloVeiculo.Cambio = Convert.ToInt32(cbCambio.SelectedValue);
                    modeloVeiculo.Combustivel = Convert.ToInt32(cbCombustivel.SelectedValue);
                    modeloVeiculo.KmRodado = int.Parse(txtKmRodado.Text);
                    modeloVeiculo.Categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    modeloVeiculo.Segmento = Convert.ToInt32(cbSegmento.SelectedValue);
                    modeloVeiculo.Porta = int.Parse(txtPortas.Text);
                    modeloVeiculo.Obs = txtObs.Text;

                    cadastro.CadastraVeiculo(modeloVeiculo);

                    MessageBox.Show("Veículo cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtPlaca.Clear();
                    txtAno.Clear();
                    txtAnoModelo.Clear();
                    txtKmRodado.Clear();
                    txtPortas.Clear();
                    txtObs.Clear();

                    txtPlaca.Focus();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Valor informado inválido", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaVeiculo()
        {

            conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            //string selecionar = "SELECT * FROM tbmodelo";

            comando = new MySqlCommand("selectmodelo", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            //A linha abaixo é responsável por criar uma tabela virtual com os dados selcionados do banco
            DataTable carrosSelecionados = new DataTable();

            //A linha abaixo faz uma recarga linha a linha dos dados selecionados 
            carrosSelecionados.Load(comando.ExecuteReader());

            //A linha abaixo é responsável por selecionar a coluna desejada 
            cbModelo.DisplayMember = "modelo";

            //A linha abaixo faz o vínculo do ID ao campo
            cbModelo.ValueMember = "codModelo";

            //A linha abaixo insere todos os dados da coluna informada no DisplayMember 
            cbModelo.DataSource = carrosSelecionados;

            //A linha abaixo deixa o primeiro item da combobox em branco
            cbModelo.SelectedIndex = -1;

            conexao.Close();

        }

        private void ListaCor()
        {

            conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            comando = new MySqlCommand("selectcor", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            DataTable CoresSelecionadas = new DataTable();

            CoresSelecionadas.Load(comando.ExecuteReader());

            cbCor.DisplayMember = "cor";

            cbCor.ValueMember = "codCor";

            cbCor.DataSource = CoresSelecionadas;

            cbCor.SelectedIndex = -1;

            conexao.Close();

        }

        private void ListaCambio()
        {

            conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            comando = new MySqlCommand("selectcambio", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            DataTable CambiosSelecionados = new DataTable();

            CambiosSelecionados.Load(comando.ExecuteReader());

            cbCambio.DisplayMember = "cambio";

            cbCambio.ValueMember = "codCambio";

            cbCambio.DataSource = CambiosSelecionados;

            cbCambio.SelectedIndex = -1;

            conexao.Close();

        }

        private void ListaCombustivel()
        {

            conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            comando = new MySqlCommand("selectcomb", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            DataTable CombSelecionados = new DataTable();

            CombSelecionados.Load(comando.ExecuteReader());

            cbCombustivel.DisplayMember = "combustivel";

            cbCombustivel.ValueMember = "codCombustivel";

            cbCombustivel.DataSource = CombSelecionados;

            cbCombustivel.SelectedIndex = -1;

            conexao.Close();

        }


        private void ListaCategoria()
        {

            conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            comando = new MySqlCommand("selectcat", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            DataTable CatSelecionadas = new DataTable();

            CatSelecionadas.Load(comando.ExecuteReader());

            cbCategoria.DisplayMember = "categoria";

            cbCategoria.ValueMember = "codCategoria";

            cbCategoria.DataSource = CatSelecionadas;

            cbCategoria.SelectedIndex = -1;

            conexao.Close();

        }

        private void ListaSegmento()
        {

            conexao = new MySqlConnection(Conexao.conector());

            conexao.Open();

            comando = new MySqlCommand("selectseg", conexao);

			comando.CommandType = CommandType.StoredProcedure;

            comando.ExecuteNonQuery();

            DataTable SegSelecionados = new DataTable();

            SegSelecionados.Load(comando.ExecuteReader());

            cbSegmento.DisplayMember = "segmento";

            cbSegmento.ValueMember = "codSegmento";

            cbSegmento.DataSource = SegSelecionados;

            cbSegmento.SelectedIndex = -1;

            conexao.Close();

        }
    }
}
