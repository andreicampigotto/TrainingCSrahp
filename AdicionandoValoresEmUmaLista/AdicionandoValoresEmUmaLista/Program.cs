using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//De forma manual;
namespace AdicionandoValoresEmUmaLista
{
	class Program
	{
		static void Main(string[] args)
		{
			//Criação da lista
			string[,] listaDeNomes = new string[10, 2];
			//Aqui cria uma forma externa de identificar nossos registros
			int IdParaLista = 0;
			//Chama o método para inserir registro passando por meio de referência nossos dois itens, lista de nomes e nossos 
			//indentificadores unicos
			InseriRegistro(ref listaDeNomes, ref IdParaLista);

			Console.WriteLine("Registro adicionados com sucesso, segue a lista de informações adicionadas: ");

			Console.ReadKey();
			//Aqui aciona novamente o inseri registros
			InseriRegistro(ref listaDeNomes, ref IdParaLista);

			Console.ReadKey();
		}

		/// <summary>
		/// Método que insere novo registro
		/// </summary>
		/// <param name="listaDeNomes"></param>
		/// <param name="IdParaLista"></param>
		public static void InseriRegistro(ref string[,] listaDeNomes, ref int IdParaLista)
		{
			//Aqui está um laço para informar o nome do registro;
			for (int i = 0; i < listaDeNomes.GetLength(0); i++)
			{	
				//Aqui definimos que o mesm deve continuar para o próximo registro
				//pois o registro já está cupado;
				if (listaDeNomes[i, 0] != null)
					continue;
				//indica que deve apenas informar o nome do nosso registro
				Console.WriteLine("Informe um nome para adicionar um registro: ");
				var nome = Console.ReadLine();

				//Cria o Id unico  com um objeto externo que mesmo após sair do laço pode ser incrementado
				listaDeNomes[i, 0] = (IdParaLista++).ToString();
				//Aqui coloca nome na lista
				listaDeNomes[i, 1] = nome;

				//Identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
				Console.WriteLine("Deseja inserir um novo registro? Sim(s) ou não (n)");
				//ReadLine para ler a opção que foi inserido ToLower para deixar caixa baixa caso tenha sido digitado em maiusculo
				var continuar = Console.ReadLine().ToString().ToLower();
				//Aqui valida se continua ou  não até que a lista esteja completa de informações

				if (continuar == "n")
					break; // para parar a aplicação caso a opção seja negativa

				//Verifica se tem espaço disponivel, se todos estão preenchidos ele cria mais espaço
				AumentaTamanhoLista(ref listaDeNomes);
			}

			//Mas agora a coisa muda
			for (int i = 0; i < listaDeNomes.GetLength(0); i++)
				//Ultiliza String format basicamente faz a mesma coisa que o $ a diferença deles é que este é um cara em grande quantidade
				//por isso acaba sendo mais rápido
				Console.WriteLine(string.Format("Registro ID: {0} - Nome: {1}", listaDeNomes[i, 0], listaDeNomes[i, 1]));

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ListaNomes"></param>
		public static void AumentaTamanhoLista(ref string[,] ListaNomes)
		{
			//Varifica se precisa criar uma lista maior
			var limiteDaLista = true;
			for (int i = 0; i < ListaNomes.GetLength(0); i++)
			{
				//Caso ainda existir registro disponivel ele seta a variavel limite da lista = false
				if (ListaNomes[i, 0] == null)
					limiteDaLista = false;
			}

			//Caso não tenha mais registro nossa variavel ficou true então indica que precisamos aumentar nossa lista
			if (limiteDaLista)
			{
				//criamos uma cópia da nossa lista para não perder os valores
				var listaCopia = ListaNomes;
				//Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaço
				ListaNomes = new string[ListaNomes.GetLength(0) + 5, 2];
				//Agora copiamos os registros da nssa lista antiga e passamos para a nova lista
				for (int i = 0; i < listaCopia.GetLength(0); i++)
				{
					//Copiamos a informação do Id
					ListaNomes[i, 0] = listaCopia[i, 0];
					//Compia as informações do nome
					ListaNomes[i, 1] = listaCopia[i, 1];

				}
				//indicamos que foi atualizado o tamanho;
				Console.WriteLine("O tamanho da lista foi atualizado. ");
			}

			ListaNomes = new string[ListaNomes.GetLength(0) + 5, 2];
		}
	}
}
