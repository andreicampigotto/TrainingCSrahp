using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_ComClass.Biblioteca
{
	public class CriaLista
	{

		string[] lista;

		public CriaLista()
		{
			lista = new string[10];
			CarregaLista();
		}

		public void CarregaLista()
		{
			for (int i = 0; i < lista.Length; i++)
				lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");

			foreach (var item in lista)
				Console.WriteLine(item);

		}
	}
}
