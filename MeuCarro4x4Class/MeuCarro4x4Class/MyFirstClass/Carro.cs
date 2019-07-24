using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
	class Carro
	{
		public int Rodas { get; set; } = 0;
		public int Portas { get; set; } = 0;
		public int Bancos { get; set; } = 0;
		public int Janelas { get; set; } = 0;

		public static Carro operator ++(Carro carro)
		{
			carro.Rodas = carro.Rodas + 5;
			return carro;
		}

		public void MostrarCarro()
		{
			Console.WriteLine($"Nosso carro: " +
				$"Quant Rodas [{Rodas}] " +
				$"Quant Portas [{Portas}] " +
				$"Quant Bancos [{Bancos}] " +
				$"Quant Janelas [{Janelas}]");
		}
	}
}
