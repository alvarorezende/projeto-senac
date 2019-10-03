namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlListaVeiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlListaVeiculos));
			this.dgvListagemVeiculos = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.txtPortas = new System.Windows.Forms.TextBox();
			this.txtObs = new System.Windows.Forms.TextBox();
			this.cbSegmento = new System.Windows.Forms.ComboBox();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.cbCor = new System.Windows.Forms.ComboBox();
			this.txtKmRodado = new System.Windows.Forms.TextBox();
			this.cbCombustivel = new System.Windows.Forms.ComboBox();
			this.txtAnoModelo = new System.Windows.Forms.TextBox();
			this.txtAno = new System.Windows.Forms.TextBox();
			this.cbCambio = new System.Windows.Forms.ComboBox();
			this.cbModelo = new System.Windows.Forms.ComboBox();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagemVeiculos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvListagemVeiculos
			// 
			this.dgvListagemVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListagemVeiculos.Location = new System.Drawing.Point(493, 63);
			this.dgvListagemVeiculos.MultiSelect = false;
			this.dgvListagemVeiculos.Name = "dgvListagemVeiculos";
			this.dgvListagemVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListagemVeiculos.Size = new System.Drawing.Size(496, 268);
			this.dgvListagemVeiculos.TabIndex = 0;
			this.dgvListagemVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagemVeiculos_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExcluir);
			this.groupBox1.Controls.Add(this.btnAtualizar);
			this.groupBox1.Controls.Add(this.txtPortas);
			this.groupBox1.Controls.Add(this.txtObs);
			this.groupBox1.Controls.Add(this.cbSegmento);
			this.groupBox1.Controls.Add(this.cbCategoria);
			this.groupBox1.Controls.Add(this.cbCor);
			this.groupBox1.Controls.Add(this.txtKmRodado);
			this.groupBox1.Controls.Add(this.cbCombustivel);
			this.groupBox1.Controls.Add(this.txtAnoModelo);
			this.groupBox1.Controls.Add(this.txtAno);
			this.groupBox1.Controls.Add(this.cbCambio);
			this.groupBox1.Controls.Add(this.cbModelo);
			this.groupBox1.Controls.Add(this.txtPlaca);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(455, 520);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Infomações do Veículo";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(285, 488);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 49;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(377, 488);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 48;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// txtPortas
			// 
			this.txtPortas.Location = new System.Drawing.Point(86, 358);
			this.txtPortas.Name = "txtPortas";
			this.txtPortas.Size = new System.Drawing.Size(121, 20);
			this.txtPortas.TabIndex = 47;
			// 
			// txtObs
			// 
			this.txtObs.Location = new System.Drawing.Point(86, 393);
			this.txtObs.Multiline = true;
			this.txtObs.Name = "txtObs";
			this.txtObs.Size = new System.Drawing.Size(366, 89);
			this.txtObs.TabIndex = 46;
			// 
			// cbSegmento
			// 
			this.cbSegmento.FormattingEnabled = true;
			this.cbSegmento.Location = new System.Drawing.Point(86, 323);
			this.cbSegmento.Name = "cbSegmento";
			this.cbSegmento.Size = new System.Drawing.Size(121, 21);
			this.cbSegmento.TabIndex = 45;
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(86, 287);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(121, 21);
			this.cbCategoria.TabIndex = 44;
			// 
			// cbCor
			// 
			this.cbCor.FormattingEnabled = true;
			this.cbCor.Location = new System.Drawing.Point(86, 81);
			this.cbCor.Name = "cbCor";
			this.cbCor.Size = new System.Drawing.Size(121, 21);
			this.cbCor.TabIndex = 43;
			// 
			// txtKmRodado
			// 
			this.txtKmRodado.Location = new System.Drawing.Point(86, 255);
			this.txtKmRodado.Name = "txtKmRodado";
			this.txtKmRodado.Size = new System.Drawing.Size(121, 20);
			this.txtKmRodado.TabIndex = 42;
			// 
			// cbCombustivel
			// 
			this.cbCombustivel.FormattingEnabled = true;
			this.cbCombustivel.Location = new System.Drawing.Point(86, 221);
			this.cbCombustivel.Name = "cbCombustivel";
			this.cbCombustivel.Size = new System.Drawing.Size(121, 21);
			this.cbCombustivel.TabIndex = 41;
			// 
			// txtAnoModelo
			// 
			this.txtAnoModelo.Location = new System.Drawing.Point(86, 150);
			this.txtAnoModelo.Name = "txtAnoModelo";
			this.txtAnoModelo.Size = new System.Drawing.Size(121, 20);
			this.txtAnoModelo.TabIndex = 40;
			// 
			// txtAno
			// 
			this.txtAno.Location = new System.Drawing.Point(86, 115);
			this.txtAno.Name = "txtAno";
			this.txtAno.Size = new System.Drawing.Size(121, 20);
			this.txtAno.TabIndex = 39;
			// 
			// cbCambio
			// 
			this.cbCambio.FormattingEnabled = true;
			this.cbCambio.Location = new System.Drawing.Point(86, 185);
			this.cbCambio.Name = "cbCambio";
			this.cbCambio.Size = new System.Drawing.Size(121, 21);
			this.cbCambio.TabIndex = 38;
			// 
			// cbModelo
			// 
			this.cbModelo.FormattingEnabled = true;
			this.cbModelo.Location = new System.Drawing.Point(86, 47);
			this.cbModelo.Name = "cbModelo";
			this.cbModelo.Size = new System.Drawing.Size(121, 21);
			this.cbModelo.TabIndex = 37;
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(86, 14);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(121, 20);
			this.txtPlaca.TabIndex = 36;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 396);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(76, 13);
			this.label12.TabIndex = 35;
			this.label12.Text = "Observações: ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 361);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 34;
			this.label11.Text = "Portas:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 326);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 13);
			this.label10.TabIndex = 33;
			this.label10.Text = "Segmento: ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 290);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 32;
			this.label9.Text = "Categoria: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 258);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 13);
			this.label8.TabIndex = 31;
			this.label8.Text = "Km Rodado: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 13);
			this.label7.TabIndex = 30;
			this.label7.Text = "Combustível: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 29;
			this.label6.Text = "Cambio:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Ano Modelo: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Ano: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Cor: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "Modelo: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Placa: ";
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Location = new System.Drawing.Point(574, 23);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(334, 20);
			this.txtPesquisar.TabIndex = 2;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(914, 21);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 3;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// tlListaVeiculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1001, 544);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtPesquisar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvListagemVeiculos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "tlListaVeiculos";
			this.Text = "Listagem de Veículos";
			((System.ComponentModel.ISupportInitialize)(this.dgvListagemVeiculos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListagemVeiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtPortas;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cbSegmento;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private System.Windows.Forms.TextBox txtAnoModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cbCambio;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
    }
}