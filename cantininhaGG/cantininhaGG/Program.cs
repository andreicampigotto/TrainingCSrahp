using cantininhaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantininhaGG
{
	class Program
	{
		static void Main(string[] args)
		{
			Cantina cantina = new Cantina();

			cantina.Venda();

			//Mostra mesada disponivel
			Console.WriteLine($"Saldo atual disponivel: {cantina.Saldo.ToString("N2")}");


			Console.ReadKey();
		}
	}
}
