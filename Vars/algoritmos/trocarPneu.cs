using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos
{
	class trocarPneu
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Seu pneu está furado?");
			string furado = Console.ReadLine();

			if (furado == "sim" || furado == "s"){
				Console.WriteLine("O carro está em movimento?");
				string estaMovimento = Console.ReadLine();
				estaMovimento = estaMovimento.ToLower();
				if (estaMovimento == "s" || estaMovimento == "sim")
				{
					estaMovimento = "s";
					while (estaMovimento == "s")
					{
						Console.WriteLine("Procure um lugar seguro para parar!");

						Console.WriteLine("Parou o carro?");
						string parouCarro = Console.ReadLine();
						parouCarro = parouCarro.ToLower();
						if (parouCarro == "n" || parouCarro == "não")
							estaMovimento = "s";

						else
							estaMovimento = "n";
					}
					Console.WriteLine("Abra a porta!");
					Console.WriteLine("Saia do carro!");
					Console.WriteLine("Feche a porta");
				}
				Console.WriteLine("Caminhe até o porta-malas");
				//Thread.sleep(10);
				Console.WriteLine("Abra o porta malas");
				Console.WriteLine("Procure as ferramentas e o step");

				Console.WriteLine("Encontrou as ferramentas e o step?");
				string encontrou = Console.ReadLine();
				encontrou = encontrou.ToLower();
				if (encontrou == "n" || encontrou == "não")
				{
					Console.WriteLine("Chame o seguro se não tem, CHOLA BOY!!");
				}
				else
				{
					Console.WriteLine("Pegue as ferramentas e o step" +
									  "\nVá ao pneu vazio" +
									  "\nEncaixe o macaco" +
									  "\nAfrouxe os parafusos" +
									  "\nLevante o carro" +
									  "\nTire os parafusos" +
									  "\nTroque a roda" +
									  "\nColoque os parafusos" +
									  "\nAbaixe o carro" +
									  "\nAperte os parafusos" +
									  "\nVá ao porta-malas com as ferramentas e step" +
									  "\nGuarde as ferramentas e step" +
									  "\nFeche o porta malas");

					Console.WriteLine("SEJA FELIZ!!");

				}
			}
			else
				Console.WriteLine("SEJA FELIZ!!");

			Console.ReadKey();
		}

	}
}

