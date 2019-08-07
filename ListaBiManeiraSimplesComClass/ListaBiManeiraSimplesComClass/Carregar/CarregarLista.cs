using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carregar
{
	class CarregarLista
	{
		//Criando nossa lista com mais de uma dimensão
		string[,] listaDeNome;// = new string[5, 2];

		/// <summary>
		/// Retorna a lista de nome apenas como leitura
		/// </summary>
		public string[,] ListaNome { get { return listaDeNome; } }

		/// <summary>
		/// Metodo Construtor que sempre recebe o nome da classe
		/// </summary>
		/// <param name="arrayBi">Array que já deve estar assinada</param>
		public CarregarLista()
		{
			/*Assina a lista no metodo contrutor com isso já deixamos a lista pronta
			 * para uso nos demais metodos se, precisar de um parametro para isso */
			listaDeNome = new string[10, 2];

		}
		/// <summary>
		/// Método que carrega as informações dentro da nossa lista criada no "MAIN" e mostra as informações logo em seguida
		/// </summary>
		/// <param name="arrayBi"> Nossa lista a ser carregada </param>
		public void CarregaInformacoesEListaEmTela()
		{
			//Usa laço simples para colocar valores no mesmo ultilizando GetLength com o parametro "0" para indicar que queremos o 
			//tamanho da primeira coluna
			for (int i = 0; i < listaDeNome.GetLength(0); i++)
			{
				//Carregando o que podemos chamar de ID, identificador do nosso registro unico
				listaDeNome[i, 0] = i.ToString();
				//Aqui apenas adicionamos uma informação extra para deixar legal "Kkkkkk"
				listaDeNome[i, 1] = $"Andrei_{i}";
			}

			//Lebrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem para realizar chamada do mesmo
			for (int i = 0; i < listaDeNome.GetLength(0); i++)
			{
				//Formatamos uma string de maneira qe os dadis sejam apresentados
				Console.WriteLine($"ID: {listaDeNome[i, 0]} - Nome: {listaDeNome[i, 1]}");
			}

		}
	}
}
