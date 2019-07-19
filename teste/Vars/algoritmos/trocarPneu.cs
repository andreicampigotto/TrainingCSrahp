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
						Console.WriteLine("==> Procure um lugar seguro para parar!");

						Console.WriteLine("Parou o carro?");
						string parouCarro = Console.ReadLine();
						parouCarro = parouCarro.ToLower();
						if (parouCarro == "n" || parouCarro == "não")
							estaMovimento = "s";

						else
							estaMovimento = "n";
					}
					Console.WriteLine("==>	Abra a porta!" +
									"\n==>	Saia do carro!" +
									"\n==>	Feche a porta\n");
				}
				Console.WriteLine("==>	Caminhe até o porta-malas");
				//Thread.sleep(10);	
				Console.WriteLine("==>	Abra o porta malas");
				Console.WriteLine("==>	Procure as ferramentas e o step");

				Console.WriteLine("Encontrou as ferramentas e o step?");
				string encontrou = Console.ReadLine();
				encontrou = encontrou.ToLower();
				if (encontrou == "n" || encontrou == "não")
				{
					Console.WriteLine("Chame o seguro se não tem, CHOLA BOY!!");
				}
				else
				{
					Console.WriteLine("\n==>	Pegue as ferramentas e o step" +
									  "\n==>	Vá ao pneu vazio" +
									  "\n==>	Encaixe o macaco" +
									  "\n==>	Afrouxe os parafusos" +
									  "\n==>	Levante o carro" +
									  "\n==>	Tire os parafusos" +
									  "\n==>	Troque a roda" +
									  "\n==>	Coloque os parafusos" +
									  "\n==>	Abaixe o carro" +
									  "\n==>	Aperte os parafusos" +
									  "\n==>	Vá ao porta-malas com as ferramentas e step" +
									  "\n==>	Guarde as ferramentas e step" +
									  "\n==>	Feche o porta malas\n");

					Console.WriteLine("\nSEJA FELIZ!!");

				}
			}
			else
				Console.WriteLine("\nSEJA FELIZ!!");

			Console.ReadKey();
		}

	}
}

