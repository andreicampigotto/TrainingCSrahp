using Aluno.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
	public class Cadastro
	{
		string[,] Alunos;
		int IdParaLista;
		Calculos formulas = new Calculos();

		/// <summary>
		/// Cabeçalho dos Sistema\\
		/// </summary>
		public void Cabecalho()
		{
			Console.WriteLine($"  ---------------------------------------------------------------------------------  " +
							  $"\n |                        Sistema Boletim Alunos Perfeitos                          | " +
							  $"\n  ---------------------------------------------------------------------------------	 ");
		}

		/// <summary>
		/// Menu Principal da Aplicação
		/// </summary>
		/// <param name="numSelecionado"> retorna para chamar no menu</param>
		/// <returns></returns>
		public int MostraMenu()
		{
			Console.Clear();
			Cabecalho();

			Console.WriteLine($"Menu principal... o que você deseja fazer?" +
							  $"\n1 - Mostrar boletim " +
							  $"\n2 - Inserir notas " +
							  $"\n3 - Altera notas " +
							  $"\n4 - Apaga registro " +
							  $"\n5 - Sai do sistema ");
			return Convert.ToInt32(Console.ReadLine());
			//return Convert.ToInt32(Console.ReadLine());
		}

		/// <summary>
		/// Menu para Inserir Novos registros
		/// </summary>
		/// <param name="Alunos"></param>
		/// <param name="IdParaLista"></param>
		public void InseriRegistros(ref string[,] Alunos, ref int IdParaLista)
		{
			Console.Clear();
			Cabecalho();
			Console.WriteLine("Menu de Inserção: ");
			Alunos = new string[2, 5];

			for (int i = 0; i < Alunos.GetLength(0); i++)
			{
				if (Alunos[i, 0] != null)
					continue;

				Alunos[i, 0] = (IdParaLista++).ToString();

				Console.WriteLine("Insira o nome do aluno: ");
				string nomeAluno = Console.ReadLine();
				Alunos[i, 1] = nomeAluno;

				Console.WriteLine("Insira a primeira nota do aluno: ");
				double.TryParse(Console.ReadLine(), out double nota1);

				Console.WriteLine("Insira a segunda nota do aluno: ");
				double.TryParse(Console.ReadLine(), out double nota2);

				Console.WriteLine("Insira a terceira nota do aluno: ");
				double.TryParse(Console.ReadLine(), out double nota3);

				double media = formulas.CalculaMedia(nota1, nota2, nota3);
				Alunos[i, 2] = media.ToString();

				Console.WriteLine("Insira o total de aulas: ");
				int.TryParse(Console.ReadLine(), out int aulas);

				Console.WriteLine("Insira o total de faltas do aluno: ");
				int.TryParse(Console.ReadLine(), out int faltas);

				int frequencia = formulas.CalculaFrequencia(aulas, faltas);
				Alunos[i, 3] = frequencia.ToString();

				Alunos[i, 4] = formulas.SituacaoAluno(media, frequencia);

			}
			for (int i = 0; i < Alunos.GetLength(0); i++)
				Console.WriteLine(string.Format("Registro ID: {0} - Aluno: {1} - Média: {2} - Frequencia: {3} - \nSituação: {4}%", Alunos[i, 0], Alunos[i, 1], Alunos[i, 2], Alunos[i, 3], Alunos[i, 4]));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Alunos"></param>
		public void AlteraRegistros(string[,] Alunos)
		{
			Console.Clear();
			Cabecalho();
			Console.WriteLine("Menu de Alteração:");

			Console.WriteLine("Informe o Id do Aluno para Alterar o registro: ");
			var capturaId = Console.ReadLine();
			for (int i = 0; i < Alunos.GetLength(0); i++)
			{
				if (capturaId == Alunos[i, 0])
				{
					Console.Clear();
					Alunos[i, 0] = (IdParaLista++).ToString();

					Console.WriteLine("Insira o nome do aluno: ");
					string nomeAluno = Console.ReadLine();
					Alunos[i, 1] = nomeAluno;

					Console.WriteLine("Insira a primeira nota do aluno: ");
					double.TryParse(Console.ReadLine(), out double nota1);

					Console.WriteLine("Insira a segunda nota do aluno: ");
					double.TryParse(Console.ReadLine(), out double nota2);

					Console.WriteLine("Insira a terceira nota do aluno: ");
					double.TryParse(Console.ReadLine(), out double nota3);

					double media = formulas.CalculaMedia(nota1, nota2, nota3);
					Alunos[i, 2] = media.ToString();

					Console.WriteLine("Insira o total de aulas: ");
					int.TryParse(Console.ReadLine(), out int aulas);

					Console.WriteLine("Insira o total de faltas do aluno: ");
					int.TryParse(Console.ReadLine(), out int faltas);

					int frequencia = formulas.CalculaFrequencia(aulas, faltas);
					Alunos[i, 3] = frequencia.ToString();

					Alunos[i, 4] = formulas.SituacaoAluno(media, frequencia);

				}
			}
			for (int i = 0; i < Alunos.GetLength(0); i++)
				Console.WriteLine(string.Format("Registro ID: {0} - Aluno: {1} - Média: {2} - Frequencia: {3} - \nSituação: {4}%", Alunos[i, 0], Alunos[i, 1], Alunos[i, 2], Alunos[i, 3], Alunos[i, 4]));

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Alunos"></param>
		public void ApagaRegistros(ref string[,] Alunos)
		{
			Console.Clear();
			Cabecalho();
			Console.WriteLine("Menu de Remoção: ");
			Console.WriteLine("Informe o Id do Aluno para remvoer um registro: ");
			var capturaId = Console.ReadLine();
			for (int i = 0; i < Alunos.GetLength(0); i++)
			{

				if (capturaId == Alunos[i, 0])
				{
					Alunos[i, 1] = "";
					Alunos[i, 2] = "";
					Alunos[i, 3] = "";
					Alunos[i, 4] = "";
					Console.WriteLine("Deseja remover o registro? Sim(s) ou não (n)");
					var continuar = Console.ReadLine().ToString().ToLower();

					if (continuar == "s")
						break;
				}


			}

			for (int i = 0; i < Alunos.GetLength(0); i++)
				Console.WriteLine(string.Format("Registro ID: {0} - Aluno: {1} - Média: {2} - Frequencia: {3} - Situação: {4}", Alunos[i, 0], Alunos[i, 1], Alunos[i, 2], Alunos[i, 3], Alunos[i, 4]));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Alunos"></param>
		public void MostrarInformacoes(string[,] Alunos)
		{
			Console.Clear();
			Cabecalho();
			Console.WriteLine("Lista de Informações: ");
			for (int i = 0; i < Alunos.GetLength(0); i++)
				Console.WriteLine(string.Format("Registro ID: {0} - Aluno: {1} - Média: {2} - Frequencia: {3} - Situação: {4}", Alunos[i, 0], Alunos[i, 1], Alunos[i, 2], Alunos[i, 3], Alunos[i, 4]));

			Console.WriteLine("Resutado apresentado com sucesso!");
			Console.WriteLine("Para retornar ao menu inicial pressione qualquer tecla.");
			Console.ReadKey();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="numSelecionado"></param>
		public void FuncoesMenu()
		{
			while (true)
			{
				//MostraMenu();
				switch (MostraMenu())
				{
					case 1: { MostrarInformacoes(Alunos); break; }

					case 2: { InseriRegistros(ref Alunos, ref IdParaLista); break; }

					case 3: { AlteraRegistros(Alunos); break; }

					case 4: { ApagaRegistros(ref Alunos); break; }

					case 5:
						{
							return;
						}
				}
			}
		}

	}

}
