using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
	class Program
	{
		static void Main(string[] args)
		{
			//Criando nossa lista com mais de uma dimensão
			string[,] listaDeNome = new string[5, 2];

			//Aqui usa apenas a referencia da nossa lista colocamos ref ao passar ela no metodo
			CarregaInformacpesEListaEmTela(ref listaDeNome);

			//Após carregar as informações e mostra em tela ele espera um comando
			Console.ReadKey();

			//Indicamos que o usuario precisa informar um número de indentificação para pesquisar um registro.
			Console.WriteLine("\nInforme o ID do registro a ser pesquisado.");
			//Aqui realiza a pesquisa somente na chamada
			//Passa a lista normalmente pois não pode alterar apenas pesquisar a informação
			//Após a virgula temos o console readline que espera nosso identificador unico
			PesquisandoInformacoesNaNossaLista(listaDeNome, Console.ReadLine());

			Console.ReadKey();
		}

		/// <summary>
		/// Método que carrega as informações dentro da nossa lista criada no "MAIN" e mostra as informações logo em seguida
		/// </summary>
		/// <param name="arrayBi"> Nossa lista a ser carregada </param>
		public static void CarregaInformacpesEListaEmTela(ref string[,] arrayBi)
		{
			//Usa laço simples para colocar valores no mesmo ultilizando GetLength com o parametro "0" para indicar que queremos o 
			//tamanho da primeira coluna
			for (int i = 0; i < arrayBi.GetLength(0); i++)
			{
				//Carregando o que podemos chamar de ID, identificador do nosso registro unico
				arrayBi[i, 0] = i.ToString();
				//Aqui apenas adicionamos uma informação extra para deixar legal "Kkkkkk"
				arrayBi[i, 1] = $"Andrei_{i}";
			}

			//Lebrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem para realizar chamada do mesmo
			for (int i = 0; i < arrayBi.GetLength(0); i++)
			{
				//Formatamos uma string de maneira qe os dadis sejam apresentados
				Console.WriteLine($"ID: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]}");
			}

		}


		/// <summary>
		/// Método que realiza a pesquisa pelo identificador unico na nossa coleção
		/// </summary>
		/// <param name="arrayBi">Nossa coleção de informações</param>
		/// <param name="pId">Nossa identificador unico</param>
		public static void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
		{
			for (int i = 0; i < arrayBi.GetLength(0); i++)
			{     
				//Realiza comparação dos moesmos tipos
				if (arrayBi[i,0] == pId)
				{
					//Mostra as informações formatadas da nossa pesquisa
					Console.WriteLine($"Informação escolhoda: Id: {arrayBi[i, 0]} - Nome: {arrayBi[i, 1]} ");
					//Aqui saimos da nossa lista mas retorna vazio "return;" pois estamos em um metodo vazio "void" 
					//que não espera retornar algo
					return;
				}
			}
			//Caso ele passe por essa linha indentificamos que ele não encontrou resultados compativeis.
			Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação.");
		}
	}
}
