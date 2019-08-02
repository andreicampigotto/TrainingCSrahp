using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipalBibliotecaHbsis.Model.LivroAutor
{
	class LivroAutor 
	{
		public int Livro { get; set; }
		public int Autor { get; set; }
		public int IdCriacao { get; set; }
		public int IdAlteracao { get; set; }
		public DateTime DataCriacao { get; set; } = DateTime.Now;
		public DateTime DataAlteracao { get; set; } = DateTime.Now;
	}
}
