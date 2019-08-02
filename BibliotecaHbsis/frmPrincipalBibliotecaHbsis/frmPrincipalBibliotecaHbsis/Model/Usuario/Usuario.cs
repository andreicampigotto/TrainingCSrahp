using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipalBibliotecaHbsis.Model.Usuario
{
	class Usuario : Informacao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
	}
}
