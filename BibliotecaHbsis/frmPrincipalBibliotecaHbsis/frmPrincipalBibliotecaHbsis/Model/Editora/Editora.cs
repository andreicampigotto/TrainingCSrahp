using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipalBibliotecaHbsis.Model.Editora
{
	public class Editora : Informacao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
	}
}
