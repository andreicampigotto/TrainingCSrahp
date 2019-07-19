using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaAdicionaValoresAumentaLista
{
	class Program
	{
		static void Main(string[] args)
		{
			//Criação da lista
			string[,] listaDeCarros = new string[1, 3];
			//Aqui cria uma forma externa de identificar nossos registros
			int IdParaLista = 0;
			//Chama o método para inserir registro passando por meio de referência nossos dois itens, lista de nomes e nossos 
			//indentificadores unicos
			InseriRegistro(ref listaDeCarros, ref IdParaLista);

			Console.ReadKey();
			//Aqui aciona novamente o inseri registros
			InseriRegistro(ref listaDeCarros, ref IdParaLista);

			Console.WriteLine("Você deseja remover algum registro? Sim(s) Não(n)");
			string controle = Console.ReadLine().ToLower();

			if (controle == "s")
				ApagaRegistro(ref listaDeCarros, ref IdParaLista);

			InseriRegistro(ref listaDeCarros, ref IdParaLista);

			Console.ReadKey();
		}

		/// <summary>
		/// Método que insere novo registro
		/// </summary>
		/// <param name="listaDeCarros"></param>
		/// <param name="IdParaLista"></param>
		public static void InseriRegistro(ref string[,] listaDeCarros, ref int IdParaLista)
		{
			//Aqui está um laço para informar o nome do registro;
			for (int i = 0; i < listaDeCarros.GetLength(0); i++)
			{
				//Aqui definimos que o mesm deve continuar para o próximo registro
				//pois o registro já está cupado;
				if (listaDeCarros[i, 0] != null)
					continue;
				//indica que deve apenas informar o nome do carro no registro
				Console.WriteLine("Informe o nome do veiculo para adicionar um registro: ");
				var nome = Console.ReadLine();

				//indica a cor do veiculo
				Console.WriteLine("Informe a cor do veiculo para adicionar um registro: ");
				var cor = Console.ReadLine();

				//Cria o Id unico  com um objeto externo que mesmo após sair do laço pode ser incrementado
				listaDeCarros[i, 0] = (IdParaLista++).ToString();
				//Aqui coloca nome na lista
				listaDeCarros[i, 1] = nome;
				//Aqui coloca a cor do vaiculo
				listaDeCarros[i, 2] = cor;

				//Identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
				Console.WriteLine("Deseja inserir um novo registro? Sim(s) ou não (n)");
				//ReadLine para ler a opção que foi inserido ToLower para deixar caixa baixa caso tenha sido digitado em maiusculo
				var continuar = Console.ReadLine().ToString().ToLower();
				//Aqui valida se continua ou  não até que a lista esteja completa de informações

				if (continuar == "n")
					break; // para parar a aplicação caso a opção seja negativa

				//Verifica se tem espaço disponivel, se todos estão preenchidos ele cria mais espaço
				AumentaTamanhoLista(ref listaDeCarros);
			}

			//Mas agora a coisa muda
			for (int i = 0; i < listaDeCarros.GetLength(0); i++)
				//Ultiliza String format basicamente faz a mesma coisa que o $ a diferença deles é que este é um cara em grande quantidade
				//por isso acaba sendo mais rápido
				Console.WriteLine(string.Format("Registro ID: {0} - Carro: {1} - Cor: {2}", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2]));

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ListaCarros"></param>
		public static void AumentaTamanhoLista(ref string[,] ListaCarros)
		{
			//Varifica se precisa criar uma lista maior
			var limiteDaLista = true;
			for (int i = 0; i < ListaCarros.GetLength(0); i++)
			{
				//Caso ainda existir registro disponivel ele seta a variavel limite da lista = false
				if (ListaCarros[i, 0] == null)
					limiteDaLista = false;
			}

			//Caso não tenha mais registro nossa variavel ficou true então indica que precisamos aumentar nossa lista
			if (limiteDaLista)
			{
				//criamos uma cópia da nossa lista para não perder os valores
				var listaCopia = ListaCarros;
				//Aqui limpamos nossa lista antiga e assinamos novamente com uma lista com mais espaço
				ListaCarros = new string[ListaCarros.GetLength(0) + 1, 3];
				//Agora copiamos os registros da nssa lista antiga e passamos para a nova lista
				for (int i = 0; i < listaCopia.GetLength(0); i++)
				{
					//Copiamos a informação do Id
					ListaCarros[i, 0] = listaCopia[i, 0];
					//Copia as informações do nome
					ListaCarros[i, 1] = listaCopia[i, 1];
					//Copia inf de cor
					ListaCarros[i, 2] = listaCopia[i, 2];

				}
				//indicamos que foi atualizado o tamanho;
				Console.WriteLine("O tamanho da lista foi atualizado. ");
			}

			ListaCarros = new string[ListaCarros.GetLength(0) + 5, 3];
		}

		public static void ApagaRegistro(ref string[,] listaDeCarros,ref int IdParaLista)
		{
			for (int i = 0; i < listaDeCarros.GetLength(0); i++)
			{
				//Aqui definimos que o mesmo deve continuar para o próximo registro
				//pois o registro já está cupado;
				//if (listaDeCarros[i, 0] != null)
					//continue;
					//indica que deve apenas informar o nome do carro no registro
				Console.WriteLine("Informe o Id do veiculo para remver um registro: ");
				var capturaId = Console.ReadLine();

				if (capturaId == listaDeCarros[i, 0])
				{
					//Apaga 
					listaDeCarros[i, 1] = "";
					//Aqui apaga a cor do veiculo
					listaDeCarros[i, 2] = "";
				}

				//Identificamos se o mesmo ainda deseja inserir registros dentro da nossa lista
				Console.WriteLine("Deseja remover o registro? Sim(s) ou não (n)");
				//ReadLine para ler a opção que foi inserido ToLower para deixar caixa baixa caso tenha sido digitado em maiusculo
				var continuar = Console.ReadLine().ToString().ToLower();
				//Aqui valida se continua ou  não até que a lista esteja completa de informações

				if (continuar == "s")
					break; // para parar a aplicação caso a opção seja positiva

				//Verifica se tem espaço disponivel, se todos estão preenchidos ele cria mais espaço
				//AumentaTamanhoLista(ref listaDeCarros);
			}

			//Mas agora a coisa muda
			for (int i = 0; i < listaDeCarros.GetLength(0); i++)
				//Ultiliza String format basicamente faz a mesma coisa que o $ a diferença deles é que este é um cara em grande quantidade
				//por isso acaba sendo mais rápido
				Console.WriteLine(string.Format("Registro ID: {0} - Carro: {1} - Cor: {2}", listaDeCarros[i, 0], listaDeCarros[i, 1], listaDeCarros[i, 2]));
		}
	}
}


