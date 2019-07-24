using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBibliotecaExterna
{
	class Program
	{
		 static void Main(string[] args)
		{
			var captura = new GetFiles();

			String[] bla = captura.RetornaArquivosDoMeuDocumentos();
			for (int i = 0; i < bla.Length; i++)
				Console.WriteLine(bla[i]);
			Console.ReadKey();

			bla = captura.RetornaArquivosImagesFiles();
			for (int i = 0; i < bla.Length; i++)
				Console.WriteLine(bla[i]);
			Console.ReadKey();

			bla = captura.RetornaArquivosGit();
			for (int i = 0; i < bla.Length; i++)
				Console.WriteLine(bla[i]);
			Console.ReadKey();
		}
	}
}
