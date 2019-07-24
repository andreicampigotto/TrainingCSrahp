using CriacaoDeLista_ComClass.Biblioteca;
//using Organizando_a_Criacao_de_Lista.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizando_a_Criacao_de_Lista
{
	class Program
	{
		static void Main(string[] args)
		{
			var criaLista = new CriaLista();

			criaLista.CarregaLista();

			Console.ReadKey();
		}
	}
}
