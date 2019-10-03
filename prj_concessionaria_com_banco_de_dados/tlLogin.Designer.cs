namespace prj_concessionaria_com_banco_de_dados
{
	partial class tlLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnesenha = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.btnentrar = new System.Windows.Forms.Button();
			this.txtsenha = new System.Windows.Forms.TextBox();
			this.txtlogin = new System.Windows.Forms.TextBox();
			this.senha = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(262, 103);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// btnesenha
			// 
			this.btnesenha.Location = new System.Drawing.Point(63, 215);
			this.btnesenha.Name = "btnesenha";
			this.btnesenha.Size = new System.Drawing.Size(156, 25);
			this.btnesenha.TabIndex = 14;
			this.btnesenha.Text = "Esqueci Minha Senha";
			this.btnesenha.UseVisualStyleBackColor = true;
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(63, 173);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 13;
			this.btncancel.Text = "Cancelar";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			// 
			// btnentrar
			// 
			this.btnentrar.Location = new System.Drawing.Point(144, 173);
			this.btnentrar.Name = "btnentrar";
			this.btnentrar.Size = new System.Drawing.Size(75, 23);
			this.btnentrar.TabIndex = 12;
			this.btnentrar.Text = "Entrar";
			this.btnentrar.UseVisualStyleBackColor = true;
			this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
			// 
			// txtsenha
			// 
			this.txtsenha.Location = new System.Drawing.Point(119, 147);
			this.txtsenha.Name = "txtsenha";
			this.txtsenha.PasswordChar = '*';
			this.txtsenha.Size = new System.Drawing.Size(100, 20);
			this.txtsenha.TabIndex = 11;
			// 
			// txtlogin
			// 
			this.txtlogin.Location = new System.Drawing.Point(119, 121);
			this.txtlogin.Name = "txtlogin";
			this.txtlogin.Size = new System.Drawing.Size(100, 20);
			this.txtlogin.TabIndex = 10;
			// 
			// senha
			// 
			this.senha.AutoSize = true;
			this.senha.Location = new System.Drawing.Point(77, 147);
			this.senha.Name = "senha";
			this.senha.Size = new System.Drawing.Size(38, 13);
			this.senha.TabIndex = 9;
			this.senha.Text = "Senha";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Usuário";
			// 
			// tlLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 277);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnesenha);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnentrar);
			this.Controls.Add(this.txtsenha);
			this.Controls.Add(this.txtlogin);
			this.Controls.Add(this.senha);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "tlLogin";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnesenha;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnentrar;
		private System.Windows.Forms.TextBox txtsenha;
		private System.Windows.Forms.TextBox txtlogin;
		private System.Windows.Forms.Label senha;
		private System.Windows.Forms.Label label1;
	}
}