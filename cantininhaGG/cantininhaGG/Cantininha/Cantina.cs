using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantininhaGG.Classes
{
	class Cantina
	{

		double mesada = 0;
		bool aux = true; 
		public double Saldo { get { return mesada; } }

		public Cantina()
		{

			mesada = 20;
		}


		/// <summary>
		/// Metodo que mostra o menu captura a opcção desejada e já implementa no menu de escolhas
		/// </summary>
		/// <returns>Retorna um double que é o valor da compra para descontar</returns>
		public double MenuLanches()
		{
			Console.Clear();
			Console.WriteLine($"\r\n ------------------ Cardapio Meu Escritório -------------------- " +
							  $"\r\n Seu mesada: {MostraSaldo()}" +
							  $"\r\n	1 - Doguinho soya       R$ 13,64" +
							  $"\r\n	2 - Coxinha de ave      R$ 4,63 " +
							  $"\r\n	3 - Kibe de pão         R$ 3,29 " +
							  $"\r\n	4 - Batata com queijo   R$ 19,99" +
							  $"\r\n	5 - Suco Do Bem	        R$ 4,99 " +
							  $"\r\n	6 - Pepsi lata          R$ 2,99");

			Console.WriteLine("Escolha uma opção do menu: ");
			var opcaoEscolhida = Console.ReadLine();

			switch (opcaoEscolhida)
			{
				case "1": { return 13.64; }

				case "2": { return 4.63; }

				case "3": { return 3.29; }

				case "4": { return 19.99; }

				case "5": { return 4.99; }

				case "6": { return 2.99; }
			}

			return 0.00;
		}

		public bool Venda()
		{
			var lancheEscolhido = MenuLanches();

			if (lancheEscolhido <= mesada)
			{// Desconta do valor do mesada na carteira
				mesada -= lancheEscolhido;
				Console.WriteLine("Compra realizada com sucesso!");
				return true;
			}
			//retorna false em caso de não conter mesada disponivel
			return false;
		}

		/// <summary>
		/// Mostra ssaldo 
		/// </summary>
		/// <returns>retorna mesada atual</returns>
		public double MostraSaldo()
		{
			return Saldo;
		}
	}
}
