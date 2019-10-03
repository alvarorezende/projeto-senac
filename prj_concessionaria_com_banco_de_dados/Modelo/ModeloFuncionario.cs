using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_concessionaria_com_banco_de_dados.Modelo
{
	class ModeloFuncionario
	{
		private int codFuncionario;
		private string nome;
		private int cargo;
		private String email;
		private String senha;

		public int CodFuncionario
		{
			get { return this.codFuncionario; }
			set { this.codFuncionario = value; }
		}
		public string Nome
		{
			get { return this.nome; }
			set { this.nome = value; }
		}
		public int Cargo
		{
			get { return this.cargo; }
			set { this.cargo = value; }
		}
		public String Email
		{
			get { return this.email; }
			set { this.email = value; }
		}
		public String Senha
		{
			get { return this.senha; }
			set { this.senha = value; }
		}

	}
}
