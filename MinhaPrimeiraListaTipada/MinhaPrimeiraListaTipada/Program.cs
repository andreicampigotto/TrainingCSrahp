using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
	class Program
	{
		static void Main(string[] args)
		{
			//O indicador <T> o tipo da minha lista com isso temos uma lista de lanche
			List<Lanche> minhaLista = new List<Lanche>();
			int cont = -1;
			while (cont < 5)
			{
				minhaLista.Add(new Lanche()
				{
					Nome = RetornaValores("Nome:"),
					Quantidade = int.Parse(RetornaValores("Quantidade")),
					Valor = double.Parse(RetornaValores("Valor"))
				});
				cont++;
			}

			//Aqui anda pela lista para mostrar em tela
			foreach (Lanche item in minhaLista)
				Console.WriteLine($"Lanches disponiveis: {item.Nome}");

			foreach (Lanche item in minhaLista)
			{
				if (item.Quantidade == 2)
				{
					minhaLista.Remove(item);
					break;
				}
			}

			/*minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));

			var meuIem = (from item in minhaLista
						  where item.Quantidade == 2
						  select item).ToList<Lanche>();*/

			foreach (var item in minhaLista)
				Console.WriteLine($"Lanches disponiveis: {item.Nome}");

			Console.ReadKey();
		}
		public static string RetornaValores(string nome)
		{
			Console.WriteLine($"Informe o valor para o campo: {nome}");
			return Console.ReadLine();
		}

	}
}

