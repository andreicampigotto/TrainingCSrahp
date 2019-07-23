using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatrs
{
	class Program
	{
		static void Main(string[] args)
		{
			var elementoX = new Teste(5, 5);
			elementoX.MostrarInformacoes();

			elementoX.AlterandoInformacoes(5,5);

			elementoX.MostrarInformacoes();

			MeninaSuperFoderoza(elementoX);
			//elementoX.AlterandoInformacoes();

			elementoX.MostrarInformacoes();

			Console.ReadKey();
		}
	}

	public static void MeninaSuperFoderoza(Teste pTeste)
	{
		pTeste.AlterandoInformacoes();
		//pTeste.MostrarInformacoes();
	}

	public class Teste
	{
		private int A { get; set; } = 0;
		private int B { get; set; } = 0;

		public Teste(int pA, int pB)
		{
			A = pA;
			B = pB;
		}
		public void AlterandoInformacoes()
		{
			A = B * 100;
		}
		public void AlterandoInformacoes(int pA, int pB)
		{
			A = pA * 2;
			B = pB * 2;
		}
		public void MostrarInformacoes()
		{
			Console.WriteLine(A + B);
		}
	}	
}
