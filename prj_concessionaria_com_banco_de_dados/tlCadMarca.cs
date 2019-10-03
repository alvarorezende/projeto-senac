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
using prj_concessionaria_com_banco_de_dados.Modelo;
using prj_concessionaria_com_banco_de_dados.Insert;

namespace prj_concessionaria_com_banco_de_dados
{
    public partial class tlCadMarca : Form

    {
        public tlCadMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadMarca_Click(object sender, EventArgs e)
        {
            ModeloMarca modeloMarca = new ModeloMarca();
            CadastroMarca cadastroMarca = new CadastroMarca();
            try
            {
                modeloMarca.Marca = txtMarca.Text;

                cadastroMarca.CadastraMarca(modeloMarca);

                MessageBox.Show("Marca cadastrada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMarca.Clear();

                txtMarca.Focus();
            }
            catch(FormatException)
            {
                MessageBox.Show("Valor informado inválido", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
