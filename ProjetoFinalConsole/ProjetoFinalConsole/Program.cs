using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] baseDeDados = new string[1, 5];
			int idDinamicoBanco = 0;

			var opcaoMenu = ApresentaMenuPrincipal();
			ExecutaMenuPrincipal(baseDeDados, opcaoMenu, idDinamicoBanco);
		}

		/// <summary>
		/// Cria um cabeçalho para o sistema.
		/// </summary>
		public static void CabecalhoSistema()
		{
			Console.WriteLine(" <><><><><><><<><><><><><><><><<><><><><><><><><><><><<><><><><><><><><><><<><>	" +
						   "\n<>                                                                              <>" +
						   "\n<>                       BEM VINDO SO SISBIO 3000                               <>" +
						   "\n<>                                                                              <>" +
						   "\n  <><><><><><><<><><><><><><><><<><><><><><><><><><><><<><><><><><><><><><><<><>	" +
						   "\n<>                                                                              <>" +
						   "\n<>                     DESENVOLVIDO POR STUDENTS S.A                            <>" +
						   "\n<>                                                                              <>" +
						   "\n  <><><><><><><<><><><><><><><><<><><><><><><><><><><><<><><><><><><><><><><<><>	");
		}
		
		/// <summary>
		/// Apresenta o Menu inicial com o cabeçalho;
		/// </summary>
		/// <returns> retona a opção escolhoda do menu;</returns>
		public static string ApresentaMenuPrincipal()
		{
			Console.Clear();
			CabecalhoSistema();
			Console.WriteLine("\n   MENU PRINCIPAL. " +
							 "\n1 - Lista de livro. " +
							 "\n2 - Inserir livro. " +
							 "\n3 - Remover livro. " +
							 "\n4 - Arquivo morto. " +
							 "\n5 - Sair do distema. " +
							 "\n                      " +
							 "\n - Digite a opção desejada: ");

			return Console.ReadLine();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseDeDados"></param>
		/// <param name="opcaoMenu"></param>
		public static void ExecutaMenuPrincipal(string[,] baseDeDados, string opcaoMenu, int idDinamicoBanco)
		{
			while (true)
			{
				switch (opcaoMenu)
				{
					case "1": { ApresentaDados(baseDeDados); };  break;

					case "2": { IsereValoresNoBanco(ref baseDeDados, ref idDinamicoBanco); }; break;

					case "3": { RetiraValoresNoBanco(ref baseDeDados); }; break;

					case "4": { ApresentaDados(baseDeDados, "true"); }; break;

					case "5":
						{	
							return;
						}


				}
				opcaoMenu = ApresentaMenuPrincipal();
			}
		}

		/// <summary>
		/// Apresenta o banco de Livros
		/// </summary>
		/// <param name="baseDeDados"> captura a base de dados do sistema</param>
		/// <param name="mostraStatusLivros"> captura se o livro está ativo ou não</param>
		public static void ApresentaDados(string[,] baseDeDados, string mostraStatusLivros = "false")
		{
			Console.Clear();
			CabecalhoSistema();
			Console.WriteLine(" ------------------ CATÁLOGO DE LIVROS ------------------ ");

			if (mostraStatusLivros == "true")
			{
				Console.Clear();
				CabecalhoSistema();
				Console.WriteLine(" ------------------ CATÁLOGO DO ARQUIVO MORTO ------------------ ");
			}
				

			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i,3] != mostraStatusLivros)
				{
					Console.WriteLine($"ID: {baseDeDados[i, 0]} " +
								$"- Titulo:{baseDeDados[i, 1]} " +
								$"- Autor:{baseDeDados[i, 2]} " +
								$"- Data ultima alteração: {baseDeDados[i, 4]}");
				}
			}
				
			
			Console.WriteLine("Resultados apresentados com sucesso!");
			Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
			Console.ReadKey();
		}

		public static void IsereValoresNoBanco(ref string[,] baseDeDados, ref int idDinamicoBanco)
		{
			Console.Clear();
			CabecalhoSistema();
			Console.WriteLine(" ------------------ Menu de insersão de livros ------------------ ");

			Console.WriteLine("Informe o titulo do livro: ");
			var tituloLivro = Console.ReadLine();

			Console.WriteLine("Informe o autor do livro: ");
			var autorLivro = Console.ReadLine();

			TamanhoDinamicoDaLista(ref baseDeDados);

			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i, 0] != null)
					continue;

				baseDeDados[i, 0] = (idDinamicoBanco++).ToString();
				baseDeDados[i, 1] = tituloLivro;
				baseDeDados[i, 2] = autorLivro;
				baseDeDados[i, 3] = "true";
				baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

				break;
			}

			Console.WriteLine("Registro cadastrado com sucesso!");
			Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
			Console.ReadKey();
		}

		/// <summary>
		/// Metodo que retira osos livros da lista e coloca no arquivo morto
		/// </summary>
		/// <param name="baseDeDados">parametro que captura a base de dados para usar</param>
		public static void RetiraValoresNoBanco(ref string[,] baseDeDados)
		{
			Console.Clear();
			CabecalhoSistema();
			Console.WriteLine(" ------------------ Menu de Retirada de livros ------------------ ");

			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i,3] != "false")
					Console.WriteLine($"ID: {baseDeDados[i, 0]} " +
								$"- Titulo:{baseDeDados[i, 1]} " +
								$"- Autor:{baseDeDados[i, 2]} " +
								$"- Data ultima alteração: {baseDeDados[i, 4]}");
			}

			Console.WriteLine("Informe o Id do Livro a ser removido: ");
			var idRemocao = Console.ReadLine();

			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i,0] != null && baseDeDados[i,0] == idRemocao )
				{
					baseDeDados[i, 3] = "false";
					baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
				}
			}
			Console.WriteLine("Operações finalizadas.");
			Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
			Console.ReadKey();
		}

		/// <summary>
		/// Metodo que cria novas linhas na lista caso o anterior não haja mais espaço
		/// </summary>
		/// <param name="baseDeDados">metodo que captura a base de dados</param>
		public static void TamanhoDinamicoDaLista(ref string[,] baseDeDados)
		{
			var limiteLista = true;

			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i,0] == null)
				{
					limiteLista = false;
				}
			}

			if (limiteLista)
			{
				var copiaLista = baseDeDados;

				baseDeDados = new string[baseDeDados.GetLength(0) + 1, 5];

				for (int i = 0; i < copiaLista.GetLength(0); i++)
				{
					baseDeDados[i, 0] = copiaLista[i, 0];
					baseDeDados[i, 1] = copiaLista[i, 1];
					baseDeDados[i, 2] = copiaLista[i, 2];
					baseDeDados[i, 3] = copiaLista[i, 3];
					baseDeDados[i, 4] = copiaLista[i, 4];
				}
			}
			Console.WriteLine("Tamanho da lista foi atualizado!");
		}
	}
}
