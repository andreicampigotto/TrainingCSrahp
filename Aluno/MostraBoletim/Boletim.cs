using Escola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostraBoletim
{
	class Boletim
	{
		static void Main(string[] args)
		{
			Cadastro opces = new Cadastro();
			/*string[,] Alunos = new string[2, 5];
			int IdParaLista = 0;

			opces.InseriRegistros(ref Alunos, ref IdParaLista);

			Console.ReadKey();

			//opces.InseriRegistros(IdParaLista);

			Console.WriteLine("Você deseja remover algum registro? Sim(s) Não(n)");
			string controle = Console.ReadLine().ToLower();

			if (controle == "s")
				opces.ApagaRegistros(ref Alunos, ref IdParaLista);

			opces.InseriRegistros(ref Alunos, ref IdParaLista);*/
			opces.FuncoesMenu();
			Console.ReadKey();
		}
	}
}

