using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
	public class AquiMostraJoinha
	{

		public void MetodoInicialDoJoinha()
		{
			Console.WriteLine("Aqui iniciamos o nosso joinha");

			Console.ReadKey();
		}

		public void MetodoDoisPontoZero(bool eQuinta)
		{
			if (eQuinta)
				Console.WriteLine("Carai mermão");

			else
				Console.WriteLine("AiAiaaiaiaiaiiii");

			Console.ReadKey();


		}

		public string[] TesteUmOperadorLegal()
		{
			return new string[2] { "BLA", "BLAbLA" };

		}
	}
}
