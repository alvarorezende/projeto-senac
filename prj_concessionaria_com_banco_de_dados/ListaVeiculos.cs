using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlListaVeiculos : Form
    {
        ListagemDLL listaDLL;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter adapter;
        DataTable tabela;
        ModeloVeiculo modeloVeiculo;
        Atualizar atualizar;
        Excluir excluir;


        public tlListaVeiculos()
        {
            InitializeComponent();

            listaDLL = new ListagemDLL();

            dgvListagemVeiculos.DataSource = listaDLL.ExibirVeiculos();

            ListaVeiculo();
            ListaCor();
            ListaCombustivel();
            ListaCambio();
            ListaCategoria();
            ListaSegmento();
        }

        public void PesquisarVeiculo(string busca)
        {
            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            try
            {
                conexao = new MySqlConnection(caminhoBanco);

                conexao.Open();

                string pesquisa = "SELECT " +
                    "V.placa, M.modelo, CO.cor, V.ano, V.ano_modelo, V.kmRodado, V.qtdPortas, CA.cambio, COM.combustivel, CAT.categoria, S.segmento, V.obsVeiculo " +
                    "FROM tbveiculo V, tbcor CO, tbmodelo M, tbcambio CA, tbcombustivel COM, tbcategoria CAT, tbsegmento S " +
                    "WHERE CONCAT(V.placa, M.modelo, CO.cor, CA.cambio, COM.combustivel, CAT.categoria, S.segmento, V.obsVeiculo) LIKE '%" + busca + "%' AND " +
                    "V.fk_modelo = M.codModelo AND V.fk_cor = CO.codCor AND V.fk_cambio = CA.codCambio " +
                    "AND V.fk_combustivel = COM.codCombustivel AND V.fk_categoria = CAT.codCategoria AND V.fk_segmento = S.codSegmento";

                comando = new MySqlCommand(pesquisa, conexao);

                adapter = new MySqlDataAdapter(comando);

                tabela = new DataTable();

                adapter.Fill(tabela);

                dgvListagemVeiculos.DataSource = tabela;

                conexao.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível concluir a sua pesquisa!" + e);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string busca = txtPesquisar.Text;
            PesquisarVeiculo(busca);
        }

        private void dgvListagemVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                //A variável linha é responsável por trazer toda a linha de cadastro de um veículo, isso só acontece pelo fato do DataGridViewRow
                DataGridViewRow linha = this.dgvListagemVeiculos.Rows[e.RowIndex];

                //linha.Cells -> pega a coluna que está indicada entre [""] pegando apenas o valor e convertendo para string 
                txtPlaca.Text = linha.Cells["placa"].Value.ToString();
                cbModelo.Text = linha.Cells["modelo"].Value.ToString();
                cbCor.Text = linha.Cells["cor"].Value.ToString();
                txtAno.Text = linha.Cells["ano"].Value.ToString();
                txtAnoModelo.Text = linha.Cells["ano_modelo"].Value.ToString();
                cbCambio.Text = linha.Cells["cambio"].Value.ToString();
                cbCombustivel.Text = linha.Cells["combustivel"].Value.ToString();
                txtKmRodado.Text = linha.Cells["kmRodado"].Value.ToString();
                cbCategoria.Text = linha.Cells["categoria"].Value.ToString();
                cbSegmento.Text = linha.Cells["segmento"].Value.ToString();
                txtPortas.Text = linha.Cells["qtdPortas"].Value.ToString();
                txtObs.Text = linha.Cells["obsVeiculo"].Value.ToString();

            }

        }

        private void ListaVeiculo()
        {
            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbmodelo";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            tabela = new DataTable();

            tabela.Load(comando.ExecuteReader());

            cbModelo.DisplayMember = "modelo";

            cbModelo.ValueMember = "codModelo";

            cbModelo.DataSource = tabela;

            conexao.Close();
        }

        private void ListaCor()
        {

            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbcor";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            tabela = new DataTable();

            tabela.Load(comando.ExecuteReader());

            cbCor.DisplayMember = "cor";

            cbCor.ValueMember = "codCor";

            cbCor.DataSource = tabela;

            conexao.Close();

        }

        private void ListaCombustivel()
        {

            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbcombustivel";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable CoresSelecionadas = new DataTable();

            CoresSelecionadas.Load(comando.ExecuteReader());

            cbCombustivel.DisplayMember = "combustivel";

            cbCombustivel.ValueMember = "codCombustivel";

            cbCombustivel.DataSource = CoresSelecionadas;

            conexao.Close();

        }

        private void ListaCambio()
        {

            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbcambio";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable CoresSelecionadas = new DataTable();

            CoresSelecionadas.Load(comando.ExecuteReader());

            cbCambio.DisplayMember = "cambio";

            cbCambio.ValueMember = "codCambio";

            cbCambio.DataSource = CoresSelecionadas;

            conexao.Close();

        }

        private void ListaCategoria()
        {

            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbcategoria";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable CoresSelecionadas = new DataTable();

            CoresSelecionadas.Load(comando.ExecuteReader());

            cbCategoria.DisplayMember = "categoria";

            cbCategoria.ValueMember = "codCategoria";

            cbCategoria.DataSource = CoresSelecionadas;

            conexao.Close();

        }

        private void ListaSegmento()
        {

            string caminhoBanco = "SERVER=127.0.0.1;PORT=3306;DATABASE=dbconcessionaria;UID=root;PASSWORD=;";

            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbsegmento";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable CoresSelecionadas = new DataTable();

            CoresSelecionadas.Load(comando.ExecuteReader());

            cbSegmento.DisplayMember = "segmento";

            cbSegmento.ValueMember = "codSegmento";

            cbSegmento.DataSource = CoresSelecionadas;

            conexao.Close();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            modeloVeiculo = new ModeloVeiculo();
            atualizar = new Atualizar();

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

            atualizar.AtualizaVeiculo(modeloVeiculo);

            dgvListagemVeiculos.DataSource = listaDLL.ExibirVeiculos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modeloVeiculo = new ModeloVeiculo();
            excluir = new Excluir();

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

            excluir.ExcluirVeiculo(modeloVeiculo);

            dgvListagemVeiculos.DataSource = listaDLL.ExibirVeiculos();

        }
    }
}
