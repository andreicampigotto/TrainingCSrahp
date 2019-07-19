using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trocarPneuCarro
{
	class trocarPneu
	{
		static void Main(string[] args)
		{
			Console.WriteLine("O carro está em movimento?");
			string estaMovimento = Console.ReadLine();
			if (estaMovimento == "s" || estaMovimento == "sim")
			{
				Console.WriteLine("Procure um lugar seguro para parar!");
				Console.WriteLine("Parou o carro?:");
				string parouCarro = Console.ReadLine();

				while (parouCarro != "s" || parouCarro != "sim")
				{
					estaMovimento = "sim";
				}

			}

		}

		
	}
}
