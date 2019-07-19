using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaInicial
{
	class BibliotecaMaisCompleta
	{
		static string[,] baseDeLivros; //= new string[5,2];
		static void Main(string[] args)
		{
			CarregaBaseDeDados();
			MenuInicial();
			Console.ReadKey();
		}

		/// <summary>
		/// Método que mostra mensagem de boas vindas
		/// </summary>
		public static void MostrarSejaBemVindo()
		{
			Console.WriteLine("		____________________________________________________  " +
							 "\n				  Sistema biblio 2000							" +
							 "\n		____________________________________________________  " +
							 "\n				Desenvolvido por SkyNet						" +
							 "\n		____________________________________________________  \n");

		}

		/// <summary>
		/// Metodo que mostra o menu com as opções de escolha.
		/// </summary>
		/// <returns> a opção escolhida. </returns>
		public static int MenuInicial()
		{
			MostrarSejaBemVindo();
			Console.WriteLine("\nO que você deseja realizar? " +
							  "\n1 - Alocar um livro. " +
							  "\n2 - Desalocar um ivro. " +
							  "\n3 - Sair do sistema. " +
							  "\nDigite a opção desejada: \n");

			//var numSelecionado = 0;
			int.TryParse(Console.ReadKey().KeyChar.ToString(), out int numSelecionado);
			//int numSelecionado = Console.ReadKey();
			MenuPrincipal(numSelecionado);
			return numSelecionado;
		}

		/// <summary>
		/// Método que carrega a base de dados dentro do sistema.
		/// </summary>
		public static void CarregaBaseDeDados()
		{
			baseDeLivros = new string[2, 2]
			{
				{"o pequeno", "sim" },
				{"o grande", "não" }
			};
		}

		/// <summary>
		/// Método que retorna se um livro pode ser alocado.
		/// </summary>
		/// <param name="nomeLivro"> Nome do livro pesquisado</param>
		/// <returns> retorna verdadeiro caso o livro esteja disponivel</returns>
		public static bool? PesquisaLivroParaAlocacao(ref string nomeLivro)
		{
			for (int i = 0; i < baseDeLivros.GetLength(0); i++)
			{
				if (ComparaNomes(nomeLivro,baseDeLivros[i,0]))
				{
					Console.WriteLine($"O livro: {nomeLivro} " +
						$" pode ser alocado?: {baseDeLivros[i, 1]}");

					return baseDeLivros[i, 1] == "sim";
				}
				
			}
			Console.WriteLine("Nenhum livro encontrado, deseja realizar busca novamente?" +
							"\nDigite 's' para sim  ou 'n' para não:");
			
			//int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
			string opcao = Console.ReadKey().KeyChar.ToString();
			//bool? novaPesquisa = null;
			if (opcao == "s")
			{
				Console.WriteLine("Digite o nome do livro a ser pesquisado:");
				nomeLivro = Console.ReadLine();
				return PesquisaLivroParaAlocacao(ref nomeLivro);
			}
			return null;
		}

		/// <summary>
		/// Método para locar o livro.
		/// </summary>
		/// <param name="nomeLivro">,nome do livro a ser alocado </param>
		/// param bool seta se pode pode ou não alocar
		public static void AlocarUmLivro(string nomeLivro, bool alocar)
		{
			for (int i = 0; i < baseDeLivros.GetLength(0); i++)
			{
				if (ComparaNomes(nomeLivro, baseDeLivros[i, 0]))
				{
					baseDeLivros[i, 1] = alocar ? "não" : "sim"; // se alocar = true coloca não, se false sim
				}
			}
			Console.Clear();
			MostrarSejaBemVindo();
			Console.WriteLine(" Livro atualizado com sucesso!\n");
		}

		/// <summary>
		/// Método para mostrar o menu de alocação
		/// </summary>
		/// <param name="numSelecionado">retorna na chamada de menu esse número para ser executado aqui</param>
		public static void AlocarUmLivro()
		{
			MostraMenuInicialDosLivros("Alocar um livro: \n");
			//MostraListaDeLivrosAtualizada();

			var nomeLivro = Console.ReadLine().ToLower();
			var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomeLivro);

			if (resultadoPesquisa != null && resultadoPesquisa == true)
			{
				Console.Clear();
				MostrarSejaBemVindo();
				Console.WriteLine("Você deseja alocar o livro? para sim(s) para não (n)");
				AlocarUmLivro(nomeLivro, Console.ReadKey().KeyChar.ToString() == "s");
				//var podeSerAlocado = PesquisaLivroParaAlocacao(nomeLivro);	
				//Console.Clear();
				MostraListaDeLivrosAtualizada();
				Console.ReadKey();
			}
			Console.WriteLine("\r\n BEY BEY!");

		}

		/// <summary>
		/// MenuPrincipal 
		/// </summary>
		/// <param name="numSelecionado"> parametro que busca o numero selecionado </param>
		public static void MenuPrincipal(int numSelecionado)
		{
			switch (numSelecionado)
			{
				case 1:
					AlocarUmLivro();
					break;
				case 2:
					DesalocarUmLivro();
					break;
				case 3:
					Console.Clear();
					MostrarSejaBemVindo();
					Console.WriteLine("BEY BEY");
					break;
			}
		}

		/// <summary>
		/// Mostra Lista de livros atualizada 
		/// </summary>
		public static void MostraListaDeLivrosAtualizada()
		{
			Console.WriteLine("Lista de livros: \n");
			for (int i = 0; i < baseDeLivros.GetLength(0); i++)
			{
				Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
			}
		}

		/// <summary>
		/// Método para desaloar um livro
		/// </summary>
		public static void DesalocarUmLivro()
		{
			MostraMenuInicialDosLivros("Desalocar um livro:");

			var nomeLivro = Console.ReadLine().ToLower();
			var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomeLivro);

			if (resultadoPesquisa != null && resultadoPesquisa == false)
			{
				Console.Clear();
				MostrarSejaBemVindo();
				Console.WriteLine("Você deseja desalocar o livro? para sim(s) para não (n)");

				AlocarUmLivro(nomeLivro, Console.ReadKey().KeyChar.ToString() == "n");
				//var podeSerAlocado = PesquisaLivroParaAlocacao(nomeLivro);	
				//Console.Clear();
				MostraListaDeLivrosAtualizada();
				Console.ReadKey();
			}
		}

		/// <summary>
		/// Método para Mostrar i Menu incial
		/// </summary>
		/// <param name="operacao">apenas mostra o nome</param>
		public static void MostraMenuInicialDosLivros(string operacao)
		{
			Console.Clear();

			MostrarSejaBemVindo();

			Console.WriteLine($"\r\n Menu - {operacao}");
			MostraListaDeLivrosAtualizada();
			Console.WriteLine("\nDigite o nome do livro para realizar a operação: ");

		}

		/// <summary>
		/// Método que compara duas strings deixando em caixa baixa e removendo espaços vazios dentro da mesma
		/// </summary>
		/// <param name="primeiro">primeira string a ser comparada</param>
		/// <param name="segundo">segunda strig a ser comparada</param>
		/// <returns>Retorna o resultado desta comparaçã</returns>
		public static bool ComparaNomes(string primeiro, string segundo)
		{
			if (primeiro.ToLower().Replace(" ", "")
					== segundo.ToLower().Replace(" ", ""))
				return true;

			return false;
		}
	}
}

