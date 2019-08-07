using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraAdrielle;

namespace Casio_Fx_911
{
	class Program
	{
		static void Main(string[] args)
		{
			var cassioDaAdrielle = new CalcAdrielle();

			Console.WriteLine($"Àrea do retangulo base {2.5} altura {7}: " + cassioDaAdrielle.CalculaAreaRetangulo(2.5, 7));

			Console.WriteLine($"Àrea do triangulo base {3.5} altura {7}: " + cassioDaAdrielle.CalculaAreaTrianguloEquilatero(3.5,7));

			Console.WriteLine($"Àrea do do circulo {4.5}:" + cassioDaAdrielle.CalculaRaioCirculo(4.5));

			Console.WriteLine($"Divisão esse {5.5} por {5} :" + cassioDaAdrielle.CalculaDivisao(5.5,5));

			Console.WriteLine($"Multiplicação esse {6.5} por {5} :" + cassioDaAdrielle.CalculaMultiplicacao(6.5, 5));


			Console.ReadKey();
		}
	}
}
