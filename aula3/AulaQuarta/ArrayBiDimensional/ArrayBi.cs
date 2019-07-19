using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBiDimensional
{
	class ArrayBi
	{
		static void Main(string[] args)
		{
			string[,] listaDeLivros = new string[2, 2]
				{{"The little", "yes"}, {"The big", "no"}};

			for (int i = 0; i < listaDeLivros.GetLength(0); i++)
			{
				var nomeLivro = listaDeLivros[i, 0];
				var disponibilidadeLivro = listaDeLivros[i, 1];

				Console.WriteLine($"Book name: {nomeLivro} Available: {disponibilidadeLivro}");
				Console.ReadKey();
			}
		}
	}
}
