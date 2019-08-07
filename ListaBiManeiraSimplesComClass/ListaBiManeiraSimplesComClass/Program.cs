using ListaBiManeiraSimplesComClass.Carregar;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
	class Program
	{
		static void Main(string[] args)
		{
			//Aqui iniciamos nosso objeto em memoria
			var carregaLista = new CarregarLista();
			
			//aqui chama o metodo para carregar a lista
			carregaLista.CarregaInformacoesEListaEmTela();

			/*Carrega novamente mas agora mostra a lista aonde colocamos todos os metodos que
			serão direcionacos para mostrar a listagem na tela do console */
			var mostrarLista = new MostrarLista();
			//chama o metodo novamente
			mostrarLista.PesquisandoInformacoesNaNossaLista(carregaLista.ListaNome, "0");

			Console.ReadKey();
		}
	}
}
