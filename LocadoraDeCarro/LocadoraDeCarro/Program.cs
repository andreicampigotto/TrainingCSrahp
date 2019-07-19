using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeCarro
{
	class Program
	{
		static string[,] baseDeCarros;
		static void Main(string[] args)
		{
			CarregaBaseDeCarros();
			//MensagemInicial();
			MostraMenuPrincipal();

			Console.ReadKey();
			
			
		}
		/// <summary>
		/// Método da mensagem de boas vindas;
		/// </summary>
		public static void MensagemInicial()
		{
			Console.WriteLine("  _________________________________________________________________ " +
							"\n     	  Bem vindo ao locadora de carros 4000				" +
							"\n  _________________________________________________________________ " +
							"\n    	  Desenvolvido por: SkyNetCorporate.com		" +
							"\n  _________________________________________________________________");
		}

		/// <summary>
		/// Método que motra o menu 
		/// </summary>
		/// <returns>retorna opção digitada para ser usado nas opções do menu</returns>
		public static int MostraMenuPrincipal()
		{
			MensagemInicial();
			Console.WriteLine("\nO que você pretende fazer? " +
							  "\n1 - Ver Lista de carros: " +
							  "\n2 - Locar um carro: " +
							  "\n3 - Devolver um carro" +
							  "\n4 - Sair do sistema: " +
							  "\nDigite a opção desejada: \n");

			int.TryParse(Console.ReadKey().KeyChar.ToString(), out int numSelecionado);
			ExecutaMenuPrincipal(numSelecionado);
			return numSelecionado;

		}

		/// <summary>
		/// Método para carregar base de dados da locadora
		/// </summary>
		public static void CarregaBaseDeCarros()
		{
			baseDeCarros = new string[4, 4]
			{
				{"fusca", "azul", "1976", "sim" },
				{"celta", "preto", "2001", "não" },
				{"brasilia", "amarela", "1950", "não" },
				{"dkw", "verde", "1965", "sim"}
			};
		}

		/// <summary>
		/// Método para a fazer a pesquisa do carro
		/// </summary>
		/// <param name="nomeCarro"> parametro para capturar o carro pelo nome</param>
		/// <returns>retorna falso para deixar o carro indisponivel</returns>
		public static bool? PesquisaCarroParaLocacao(ref string nomeCarro)
		{
			for (int i = 0; i < baseDeCarros.GetLength(0); i++)
			{
				if (ComparaNomes(nomeCarro, baseDeCarros[i, 0]))
				{
					Console.WriteLine($"O carro: {nomeCarro} " +
						$" pode ser locado?: {baseDeCarros[i, 3]}");

					return baseDeCarros[i, 3] == "sim";
				}
			}
			Console.WriteLine("Nenhum carro encontrado, deseja realizar busca novamente?" +
							"\nDigite 's' para sim  ou 'n' para não:");

			//int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
			string opcao = Console.ReadKey().KeyChar.ToString();
			//bool? novaPesquisa = null;
			if (opcao == "s")
			{
				Console.WriteLine("\nDigite o nome do carro a ser atualizado:");
				nomeCarro = Console.ReadLine();
				return PesquisaCarroParaLocacao(ref nomeCarro);
			}
			return null;
		}

		/// <summary>
		/// Método para deixa o carro indisponivel
		/// </summary>
		/// <param name="nomeCarro">parametro para capturar o nome do carro</param>
		public static void AtualizaSituacaoDoCarro(string nomeCarro, bool locar)
		{
			for (int i = 0; i < baseDeCarros.GetLength(0); i++)
			{
				if (ComparaNomes(nomeCarro, baseDeCarros[i, 0]))
					baseDeCarros[i, 3] = locar ? "não" : "sim";
			}
			Console.Clear();
			MensagemInicial();
			Console.WriteLine("Carro atualizado com sucesso!");
			MostraListaDeCarrosAtualizada();
		}

		/// <summary>
		/// Método que executa as ações para se locar um carro
		/// </summary>
		public static void LocarUmCarro()
		{
			MostraListaDeCarrosAtualizada();
			MostraMenuInicialDosCarros("Locar um Carro: \n");
			var nomeCarro = Console.ReadLine();
			var resultadoPesquisa = PesquisaCarroParaLocacao(ref nomeCarro);

			if (resultadoPesquisa != null && resultadoPesquisa == true)
			{
				Console.Clear();
				MensagemInicial();
				MostraListaDeCarrosAtualizada();
				Console.WriteLine($"Você deseja locar o carro? {nomeCarro} para sim(s) para não (n)");
				AtualizaSituacaoDoCarro(nomeCarro, Console.ReadKey().KeyChar.ToString() == "s");
				Console.ReadKey();
			}
			Console.WriteLine("\r\n BEY BEY!");

		}
	

		/// <summary>
		/// Método para Devolver um carro
		/// </summary>
		public static void DevolucaoDeCarro()
		{
			MostraListaDeCarrosAtualizada();
			MostraMenuInicialDosCarros("Devolver um carro: ");

			var nomeCarro = Console.ReadLine().ToLower();
			var resultadoPesquisa = PesquisaCarroParaLocacao(ref nomeCarro);

			if (resultadoPesquisa != null && resultadoPesquisa == false)
			{
				Console.Clear();
				MensagemInicial();
				Console.WriteLine($"Você deseja devolver o carro? {nomeCarro} para sim(s) para não (n)");

				AtualizaSituacaoDoCarro(nomeCarro, Console.ReadKey().KeyChar.ToString() == "n");
				Console.ReadKey();
			}
			Console.WriteLine("BEY BEY!");
		}

		/// <summary>
		/// Método para executar as opções do menu
		/// </summary>
		/// <param name="numSelecionado">se refere a opção escolhida do menu </param>
		public static void ExecutaMenuPrincipal(int numSelecionado)
		{
			Console.Clear();
			MensagemInicial();

			switch (numSelecionado)
			{
				case 1:
					Console.WriteLine("Lista de Carros:");
					MostraListaDeCarrosAtualizada();
					Console.WriteLine("\nVocê deseja voltar ao menu principal? para sim(s) para não (n)");
					if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
					{
						Console.Clear();
						MostraMenuPrincipal();
					}
					Console.Clear();
					Console.WriteLine("\nBEY BEY!");
					break;

				case 2:
					LocarUmCarro();
					break;

				case 3:
					DevolucaoDeCarro();
					break;

				case 4:
					Console.WriteLine("\nBEY BEY!");
					break;

			}
			Console.Clear();
			//ExecutaMenuPrincipal(numSelecionado);
			MostraMenuPrincipal();

		}

		/// <summary>
		/// Mostra a Lista de carros já atualizada
		/// </summary>
		public static void MostraListaDeCarrosAtualizada()
		{
			for (int i = 0; i < baseDeCarros.GetLength(0); i++)
				Console.WriteLine($"Modelo:  {baseDeCarros[i, 0]} Cor: {baseDeCarros[i, 1]} Ano: {baseDeCarros[i, 2]} Disponivel: {baseDeCarros[i, 3]}");
		}

		/// <summary>
		/// Método para mostrar o Menu inicial junto com o menu que se atualiza
		/// </summary>
		/// <param name="operacao">captura o nome da operação para persolanizar</param>
		public static void MostraMenuInicialDosCarros(string operacao)
		{
			Console.Clear();

			MensagemInicial();
			
			Console.WriteLine($"\r\nMenu - {operacao}");

			MostraListaDeCarrosAtualizada();

			Console.WriteLine("\nDigite o nome do carro para realizar a operação: ");

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


