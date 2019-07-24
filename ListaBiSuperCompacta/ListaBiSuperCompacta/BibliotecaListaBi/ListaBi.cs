using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
	class ListaBi
	{
		string[,] listaBi;

		//public string[,] ListaBi { get { return listaBi; } }
		
		/// <summary>
		/// Iniciamos a lista bi, agora iniciamos a instancia dela ela já vem com a 
		/// lista carregada
		/// </summary>
		public ListaBi()
		{
			listaBi = new string[5, 2];
			/*Ao chamar esse metodo no contrutor, nossa lista já vai estar carregada 
			 ao iniciar a intância "joga para a memoria"*/
			CarregaListaBi();
		}

		/// <summary>
		/// Aqui já carregamos a lista quando este metodo é chamado
		/// </summary>
		public void CarregaListaBi()
		{
			for (int i = 0; i < listaBi.GetLength(0); i++)
			{
				listaBi[i, 0] = i.ToString();
				listaBi[i, 1] = $"Andrei_{i}";
				//Ao adicionar o registro na lista já mostramos na tela
				Console.WriteLine($"Id: {i} Nome: Andrei_{i}");
			}
		}

		/// <summary>
		/// Aqui temos o metodo que realiza a pesquisa das informações em nossa lista
		/// </summary>
		/// <param name="idPesquisa">Aqui vai o Id da nossa informação</param>
		public void PesquisaLista(string idPesquisa)
		{
			for (int i = 0; i < listaBi.GetLength(0); i++)
			{
				if (listaBi[i,0] == idPesquisa)
				{
					Console.WriteLine("Resultado encontrado com suuuuuuuuuuuuuucecho!");
					Console.WriteLine($"Você pesquisou pelo registro: {listaBi[i, 1]}");
					//sai do metodo -- ele não é mais necessario pois a classe é void
					return;
				}
			}

			Console.WriteLine("Nenhum registro envontrado com esse Id");
		}


	}
}
