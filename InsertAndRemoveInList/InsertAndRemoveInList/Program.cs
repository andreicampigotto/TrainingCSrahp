using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveInList
{
	class Program
	{
		static void Main(string[] args)
		{
			//cria a nossa base de dados inicial
			string[,] baseDeDados = new string[2, 5];

			//Indicador dos registros realizados no sistema
			int indiceBaseDeDados = 0;
			
			//Apresentação inicial do SO.
			Console.WriteLine("Iniciando o sistema de lista Nome e Idade...");
			// Criamos a variavel fora
			var escolhaInicial = ApresentaMenuInicial();
			//Looping infinito pra dar merda
			while (true)
			{
				//inicia a escolha do menu;
				switch (escolhaInicial)
				{
						//Mostra os Valores armazenados
					case "1": { MostrarInformacoes(baseDeDados);  } break;

						//Insere novos valores
					case "2": { IsereValoresNaLista(ref baseDeDados, ref indiceBaseDeDados); } break;

						//Remove Valores
					case "3": { RemoveInformacoes(ref baseDeDados); } break;
						
						//Menu que mostra dados desativados do sistema
					case "4": { MostrarInformacoes(baseDeDados, "true"); }; break;

						//Sai do sistema
					case "5": { //Return dentro do nosso caso de escolha ele sai do nosso metodo principal ou que estamos no contexto
							return;
						} 
				}
				escolhaInicial = ApresentaMenuInicial();
			}
		}

		/// <summary>
		/// Apresenta as informaões do menu inicial
		/// </summary>
		/// <returns>Retorna o menu escolhido </returns>
		public static string ApresentaMenuInicial()
		{
			Console.Clear();
			Console.WriteLine("Menu");
			Console.WriteLine("1 - Listar Informações.");
			Console.WriteLine("2 - Inserir um novo registro.");
			Console.WriteLine("3 - Remover um registro.");
			Console.WriteLine("4 - Lista as informações desativadas.");
			Console.WriteLine("5 - Sair do sistema.");
			Console.WriteLine("Digite o número da opção desejada: ");
			return Console.ReadLine();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseDeDados"></param>
		/// <param name="indiceBaseDeDados"></param>
		public static void IsereValoresNaLista(ref string[,] baseDeDados, ref int indiceBaseDeDados)
		{
			Console.WriteLine("----------- Inserindo valores na lista ------------------");

			Console.WriteLine("Informe um nome: ");
			//Pegamos informaçoes digitada pelo usuario, aqui neste momento esperando idade
			var nome = Console.ReadLine();

			Console.WriteLine("Informe a idade: ");
			//Pega idade digitada pelo usuario
			var idade = Console.ReadLine();

			//Inicia o laço de repetição para varrer nossa base de sados
			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i, 0] != null)
					continue;
				//Indentifica de maneira unica os registros "(" e ")" garante que ele incrementa antes de fazer a conversão para string
				baseDeDados[i, 0] = (indiceBaseDeDados++).ToString();
				//Carrega na segunda coluna o valor "nome";
				baseDeDados[i, 1] = nome;
				//carrega na terceira coluna o valor "idade"
				baseDeDados[i, 2] = idade;
				//Carega a coluna que identifica se o registro está ativo.
				baseDeDados[i, 3] = "true";
				//Identificamos agora a data e hora de criação dos dados dentro do sistema	
				baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
				//Finaliza aqui para apenas inserir um registro por vez
				break;
			}
			//Informa ao usuario que finalizou o registro e agora ira voltar ao menu inicial..
			Console.WriteLine("Registro cadastrado com sucesso");
			Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
			Console.ReadKey();
		}

		/// <summary>
		/// Mostra dados que estão dentro da baseDeDados
		/// </summary>
		/// <param name="baseDeDados">Base de dados para a leitura e mostra para o usuario</param>
		/// <param name="mostrarRegistrosNAtivos">Quando identificado o valor true, o mesmo mostra os valores que mão estão ativos dentro do sistema.</param>
		public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistrosNAtivos = "false")
		{
			Console.WriteLine("Apresentação das informações dentro da base de dados. ");
			//Comparação que identifica visualmente quais dados está sendo mostrado
			if (mostrarRegistrosNAtivos == "true")
				Console.WriteLine("Registros desativados dentro do sistema.");
			//Laço simples aonde o mesmo mostra de maneira formatada as informações
			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				if (baseDeDados[i,3] != mostrarRegistrosNAtivos)
				{
					//Aqui deicamos mmostrar as informações que foram desabilitadas dentro do sistema.,.;
					Console.WriteLine($"ID: {baseDeDados[i, 0]} " +
								$"- Nome: {baseDeDados[i, 1]} - " +
								$"Idade: {baseDeDados[i, 2]} - " +
								$"Data da alteração: {baseDeDados[i,4]}. ");
				}
				
			}
			Console.WriteLine("Resutado apresentado com sucesso!");
			Console.WriteLine("Para retornar ao menu inicial pressione qualquer tecla.");
			Console.ReadKey();			
		}

		/// <summary>
		/// Mostra as informações dentro da nossa lista de dados"base de dados"
		/// </summary>
		/// <param name="baseDeDados">base de dados para a leitura e mostrar pro usuario</param>
		public static void RemoveInformacoes(ref string[,] baseDeDados)
		{
			Console.WriteLine("---------- Menu de remoção de registros do sistema ---------------");

			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{	
				//Verifica para remover apenas dados ativos
				if (baseDeDados[i, 2] == "false")
					Console.WriteLine($"ID: {baseDeDados[i, 0]} " +
							$"- Nome: {baseDeDados[i, 1]} - " +
							$"Idade: {baseDeDados[i, 2]}  ");

			}
			
			//Indica ao usuario informad o id dentro do sistema para remover
			Console.WriteLine("Informe o id do registro a ser removido: ");
			var id = Console.ReadLine();

			//laço para remover registro se existir
			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				//Compara se o que o usuario digitou é igual ao registro e valida para excluir
				if (baseDeDados[i,0] != null &&
					baseDeDados[i,0] == id)
					//baseDeDados[i, 0] = null;
				{	//Agora este identificador é boolean
					baseDeDados[i, 3] = "false";
					//Aqui indicamos a data que foi alterado o registro
					baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
				}
			}

			Console.WriteLine("operação finalizada.");
			Console.WriteLine("Para retornar ao menu principal selecione qualuqer tecla. ");
			Console.ReadKey();
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseDeDados"></param>
		public static void AumentaTamanhoLista(ref string[,] baseDeDados)
		{
			//Varifica se precisa criar uma lista maior
			var limiteDaLista = true;
			for (int i = 0; i < baseDeDados.GetLength(0); i++)
			{
				//Caso ainda existir registro disponivel ele seta a variavel limite da lista = false
				if (baseDeDados[i, 0] == null)
					limiteDaLista = false;
			}

			//Caso não tenha mais registro nossa variavel ficou true então indica que precisamos aumentar nossa lista
			if (limiteDaLista)
			{
				//criamos uma cópia da nossa lista para não perder os valores
				var listaCopia = baseDeDados;
				//Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaço
				baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];
				//Agora copiamos os registros da nssa lista antiga e passamos para a nova lista
				for (int i = 0; i < listaCopia.GetLength(0); i++)
				{
					//Copiamos a informação do Id
					baseDeDados[i, 0] = listaCopia[i, 0];
					//Compia as informações do nome
					baseDeDados[i, 1] = listaCopia[i, 1];
					//Compia as informações do idade
					baseDeDados[i, 2] = listaCopia[i, 2];
					//Identificador se o registro está ativo
					baseDeDados[i, 2] = listaCopia[i, 3];
					//Data alteração deste registro
					baseDeDados[i, 2] = listaCopia[i, 4];
				}
				//indicamos que foi atualizado o tamanho;
				Console.WriteLine("O tamanho da lista foi atualizado. ");
			}

			//baseDeDados = new string[baseDeDados.GetLength(0) + 1, 5];
		}
	}
}
