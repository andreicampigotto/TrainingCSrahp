using BibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
	class Program
	{
		static void Main(string[] args)
		{
			Operadores bla = new Operadores();
			Console.WriteLine(bla.Adicao(1, 1)); 
			Console.ReadKey();
		}
	}
}
