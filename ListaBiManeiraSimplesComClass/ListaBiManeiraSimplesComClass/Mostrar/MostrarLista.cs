using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostrar
{
	class MostrarLista
	{
		/// <summary>
		/// Método que realiza a pesquisa pelo identificador unico na nossa coleção
		/// </summary>
		/// <param name="arrayBi">Nossa coleção de informações</param>
		/// <param name="pId">Nossa identificador unico</param>
		public void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
		{
			for (int i = 0; i < arrayBi.GetLength(0); i++)
			{
				//Realiza comparação dos moesmos tipos
				if (arrayBi[i, 0] == pId)
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
