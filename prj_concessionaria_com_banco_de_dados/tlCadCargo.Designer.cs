namespace prj_concessionaria_com_banco_de_dados
{
	partial class tlCadCargo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlCadCargo));
			this.btncadastrar = new System.Windows.Forms.Button();
			this.txtcargo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btncadastrar
			// 
			this.btncadastrar.Location = new System.Drawing.Point(184, 79);
			this.btncadastrar.Name = "btncadastrar";
			this.btncadastrar.Size = new System.Drawing.Size(75, 23);
			this.btncadastrar.TabIndex = 5;
			this.btncadastrar.Text = "Cadastrar";
			this.btncadastrar.UseVisualStyleBackColor = true;
			// 
			// txtcargo
			// 
			this.txtcargo.Location = new System.Drawing.Point(60, 12);
			this.txtcargo.Name = "txtcargo";
			this.txtcargo.Size = new System.Drawing.Size(199, 20);
			this.txtcargo.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Cargo";
			// 
			// tlCadCargo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 120);
			this.Controls.Add(this.btncadastrar);
			this.Controls.Add(this.txtcargo);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "tlCadCargo";
			this.Text = "Cadastrar Cargo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btncadastrar;
		private System.Windows.Forms.TextBox txtcargo;
		private System.Windows.Forms.Label label1;
	}
}