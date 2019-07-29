using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Carros> listaCarros = new List<Carros>();
			ExecutaMenu(listaCarros);
		}

		public static int MostraMenu()
		{
		
			Console.WriteLine($"\r\n -------- Menu Principal --------" +
							  $"\r\n1 - Lista de Carros " +
							  $"\r\n2 - Adiciona novos carros " +
							  $"\r\nDigite uma opção: ");


			return int.Parse(Console.ReadLine());
		}

		public static void ExecutaMenu(List<Carros> listaCarros)
		{
			//MostraMenu();

			int auxMenu = MostraMenu();

			while (true)
			{
				switch (auxMenu)
				{
					case 1:
						{ ListaMenu(listaCarros); }
						break;

					case 2:
						{ AdicicionaCarros(listaCarros); }
						break;
				}

				auxMenu = MostraMenu();
			}

			//auxMenu = ExecutaMenu(listaCarros);
		}

		public static void ListaMenu(List<Carros> listaCarros)
		{
			foreach (var item in listaCarros)
				Console.WriteLine($"Lista de carros: \tAno: {item.Ano} \tModelo: {item.Modelo} \tCAvalos: {item.Cv} \tPlaca: {item.Placa} ");
		}

		public static void AdicicionaCarros(List<Carros> listaCarros)
		{
			listaCarros.Add(new Carros()
			{
				Ano = RetornaValores("Quantidade"),
				Modelo = RetornaValores("Modelo:"),
				Cv = int.Parse(RetornaValores("Cavalos")),
				Placa = RetornaValores("Placa")
			});
		}

		public static string RetornaValores(string nome)
		{
			Console.WriteLine($"Informe o valor para o campo: {nome}");
			return Console.ReadLine();
		}
	}
}
