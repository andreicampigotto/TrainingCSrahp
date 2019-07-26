using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoinha
{
	class Program
	{
		static void Main(string[] args)
		{
			new AquiMostraJoinha().MetodoInicialDoJoinha();

			new AquiMostraJoinha().MetodoDoisPontoZero(true);

			new AquiMostraJoinha().MetodoDoisPontoZero(false);

			Console.WriteLine(new AquiMostraJoinha().TesteUmOperadorLegal());
			//Oper~ção pesada como leitura e gravação na memoria
			var otroCaraParaRealizarOTeste = new AquiMostraJoinha().TesteUmOperadorLegal();
			//Contagem de todos os registros da nossa lista
			var tamanhoDaLista = otroCaraParaRealizarOTeste.Length;
			//Nosso for agora está mais rapido
			for (int i= 0; i < tamanhoDaLista; i++)
			{
				Console.WriteLine(otroCaraParaRealizarOTeste[i]);
			}

			Console.ReadKey();
			//Console.ReadKey();
		}
	}
}
