namespace prj_concessionaria_com_banco_de_dados
{
    partial class tlHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlHome));
			this.btnCadVeiculo = new System.Windows.Forms.Button();
			this.btnCadMarca = new System.Windows.Forms.Button();
			this.btnCadModelo = new System.Windows.Forms.Button();
			this.ltVeículosCadastrados = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadatrarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnListaFuncionarios = new System.Windows.Forms.Button();
			this.btnCadFuncionario = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCadVeiculo
			// 
			this.btnCadVeiculo.Location = new System.Drawing.Point(12, 64);
			this.btnCadVeiculo.Name = "btnCadVeiculo";
			this.btnCadVeiculo.Size = new System.Drawing.Size(74, 43);
			this.btnCadVeiculo.TabIndex = 0;
			this.btnCadVeiculo.Text = "Cadastrar Veículo";
			this.btnCadVeiculo.UseVisualStyleBackColor = true;
			this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
			// 
			// btnCadMarca
			// 
			this.btnCadMarca.Location = new System.Drawing.Point(104, 64);
			this.btnCadMarca.Name = "btnCadMarca";
			this.btnCadMarca.Size = new System.Drawing.Size(74, 43);
			this.btnCadMarca.TabIndex = 1;
			this.btnCadMarca.Text = "Cadastrar Marca";
			this.btnCadMarca.UseVisualStyleBackColor = true;
			this.btnCadMarca.Click += new System.EventHandler(this.btnCadMarca_Click);
			// 
			// btnCadModelo
			// 
			this.btnCadModelo.Location = new System.Drawing.Point(196, 64);
			this.btnCadModelo.Name = "btnCadModelo";
			this.btnCadModelo.Size = new System.Drawing.Size(74, 43);
			this.btnCadModelo.TabIndex = 2;
			this.btnCadModelo.Text = "Cadastrar Modelo";
			this.btnCadModelo.UseVisualStyleBackColor = true;
			this.btnCadModelo.Click += new System.EventHandler(this.btnCadModelo_Click);
			// 
			// ltVeículosCadastrados
			// 
			this.ltVeículosCadastrados.Location = new System.Drawing.Point(12, 137);
			this.ltVeículosCadastrados.Name = "ltVeículosCadastrados";
			this.ltVeículosCadastrados.Size = new System.Drawing.Size(74, 43);
			this.ltVeículosCadastrados.TabIndex = 3;
			this.ltVeículosCadastrados.Text = "Veículos Cadastrados";
			this.ltVeículosCadastrados.UseVisualStyleBackColor = true;
			this.ltVeículosCadastrados.Click += new System.EventHandler(this.ltVeículosCadastrados_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(298, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVeículoToolStripMenuItem,
            this.cadastrarModeloToolStripMenuItem,
            this.cadatrarMarcaToolStripMenuItem});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			// 
			// cadastrarVeículoToolStripMenuItem
			// 
			this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
			this.cadastrarVeículoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.cadastrarVeículoToolStripMenuItem.Text = "Cadastrar Veículo";
			// 
			// cadastrarModeloToolStripMenuItem
			// 
			this.cadastrarModeloToolStripMenuItem.Name = "cadastrarModeloToolStripMenuItem";
			this.cadastrarModeloToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.cadastrarModeloToolStripMenuItem.Text = "Cadastrar Modelo";
			// 
			// cadatrarMarcaToolStripMenuItem
			// 
			this.cadatrarMarcaToolStripMenuItem.Name = "cadatrarMarcaToolStripMenuItem";
			this.cadatrarMarcaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.cadatrarMarcaToolStripMenuItem.Text = "Cadatrar Marca";
			// 
			// listarToolStripMenuItem
			// 
			this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.modeloToolStripMenuItem});
			this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
			this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.listarToolStripMenuItem.Text = "Listar";
			// 
			// marcaToolStripMenuItem
			// 
			this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
			this.marcaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.marcaToolStripMenuItem.Text = "Marca";
			// 
			// modeloToolStripMenuItem
			// 
			this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
			this.modeloToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.modeloToolStripMenuItem.Text = "Modelo";
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.ajudaToolStripMenuItem.Text = "Ajuda";
			this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
			// 
			// btnListaFuncionarios
			// 
			this.btnListaFuncionarios.Location = new System.Drawing.Point(195, 137);
			this.btnListaFuncionarios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnListaFuncionarios.Name = "btnListaFuncionarios";
			this.btnListaFuncionarios.Size = new System.Drawing.Size(75, 43);
			this.btnListaFuncionarios.TabIndex = 8;
			this.btnListaFuncionarios.Text = "Lista Funcionario";
			this.btnListaFuncionarios.UseVisualStyleBackColor = true;
			this.btnListaFuncionarios.Click += new System.EventHandler(this.btnListaFuncionarios_Click);
			// 
			// btnCadFuncionario
			// 
			this.btnCadFuncionario.Location = new System.Drawing.Point(104, 137);
			this.btnCadFuncionario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnCadFuncionario.Name = "btnCadFuncionario";
			this.btnCadFuncionario.Size = new System.Drawing.Size(75, 43);
			this.btnCadFuncionario.TabIndex = 7;
			this.btnCadFuncionario.Text = "Cadastrar Funcionario";
			this.btnCadFuncionario.UseVisualStyleBackColor = true;
			this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
			// 
			// tlHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 236);
			this.Controls.Add(this.btnListaFuncionarios);
			this.Controls.Add(this.btnCadFuncionario);
			this.Controls.Add(this.ltVeículosCadastrados);
			this.Controls.Add(this.btnCadModelo);
			this.Controls.Add(this.btnCadMarca);
			this.Controls.Add(this.btnCadVeiculo);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "tlHome";
			this.Text = "Home";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.Button btnCadMarca;
        private System.Windows.Forms.Button btnCadModelo;
        private System.Windows.Forms.Button ltVeículosCadastrados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadatrarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
		private System.Windows.Forms.Button btnListaFuncionarios;
		private System.Windows.Forms.Button btnCadFuncionario;
	}
}

