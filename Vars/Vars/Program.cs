using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vars
{
	class Program
	{
		static void Main(string[] args)
		{
			var bla = 0;
			Console.WriteLine(bla);
			//Console.ReadKey();
			#region 

			string[] nomes = new string[2];
			string[] idades = new string[10];

			for (int i = 0; i < nomes.Length; i++)
			{

				//while (nomes[i] == null || nomes[i] == "")
				//{
					//Console.WriteLine("Informe nome, idade e peso:");

					nomes[i] = $"Nome: {IsValid("", "Nome")} " +
							   $" Idade: {IsNumberFormat(IsValid("", "idade"), "00")} " +
							   $" Peso: {IsNumberFormat(IsValid("" , "peso"), "N2")} kg";

					//nomes[i] = $"Nome: {IsValid(Console.ReadLine() , "Nome")} " +
					//		   $"Idade: {IsValid(Console.ReadLine(), "idade")} " +
					//		   $"Peso: {IsValid(Console.ReadLine() + "kg", "peso")}" ;
					

					//Console.Write("Digite seu nome: ");
					//nomes[i] = Console.ReadLine();
				//}

				//Console.WriteLine("Digite seu idade: ");
				////nomes[i] = nomes[i] + " " + Console.ReadLine();
				//idades[i] = Console.ReadLine();

				Console.Clear();

			}
			#endregion

			for (int i = 0; i < nomes.Length; i++)
				Console.WriteLine(nomes[i]);

			Console.ReadKey();
		}

		private static string IsValid(string value, string fieldName)
		{
			var retorno = value;
			while (string.IsNullOrEmpty(retorno) || string.IsNullOrWhiteSpace(retorno))
			{
				Console.WriteLine($"Informe um valor para o campo {fieldName}: ");
				retorno = Console.ReadLine();
			}
			return retorno;
		}
		private static string IsNumberFormat(object values, string format)
		{
			//var retorno = values;
			int.TryParse(values.ToString(), out int retorno);

			return retorno.ToString(format);
		}

	}
}
