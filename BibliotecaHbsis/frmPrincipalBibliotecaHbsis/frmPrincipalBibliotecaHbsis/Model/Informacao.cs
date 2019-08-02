using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipalBibliotecaHbsis.Model
{
	public abstract class Informacao 
	{
		public bool Ativo { get; set; } = true;
		public int IdCriacao { get; set; }
		public int IdAlteracao { get; set; }
		public DateTime DataCriacao { get; set; } = DateTime.Now;
		public DateTime DataAlteracao { get; set; } = DateTime.Now;
	}
}
