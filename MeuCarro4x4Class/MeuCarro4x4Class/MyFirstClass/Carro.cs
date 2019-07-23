using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
	class Carro
	{
		int rodas = 0;
		int portas = 0;
		int bacos = 0;
		int janelas = 0;

		public void MostrarCarro()
		{
			Console.WriteLine($"Nosso carro: " +
				$"Quant Rodas [{rodas}] " +
				$"Quant Portas [{portas}] " +
				$"Quant Bancos [{bacos}] " +
				$"Quant Janelas [{janelas}]");
		}
	}
}
