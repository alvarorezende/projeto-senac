namespace prj_concessionaria_com_banco_de_dados
{
	partial class tlAlterarSenha
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
			this.btnAlterar = new System.Windows.Forms.Button();
			this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
			this.txtNovaSenha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(206, 82);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(75, 23);
			this.btnAlterar.TabIndex = 9;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// txtConfirmaSenha
			// 
			this.txtConfirmaSenha.Location = new System.Drawing.Point(102, 41);
			this.txtConfirmaSenha.Name = "txtConfirmaSenha";
			this.txtConfirmaSenha.Size = new System.Drawing.Size(180, 20);
			this.txtConfirmaSenha.TabIndex = 8;
			// 
			// txtNovaSenha
			// 
			this.txtNovaSenha.Location = new System.Drawing.Point(102, 12);
			this.txtNovaSenha.Name = "txtNovaSenha";
			this.txtNovaSenha.Size = new System.Drawing.Size(180, 20);
			this.txtNovaSenha.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Confirmar Senha: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nova Senha: ";
			// 
			// tlAlterarSenha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 117);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.txtConfirmaSenha);
			this.Controls.Add(this.txtNovaSenha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "tlAlterarSenha";
			this.Text = "tlAlterarSenha";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.TextBox txtConfirmaSenha;
		private System.Windows.Forms.TextBox txtNovaSenha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}