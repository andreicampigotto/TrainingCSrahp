using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificador
{
	class VerificadorDeIdade
	{
		static void Main(string[] args)
		{
			CapturaInformacoes();
			Console.ReadKey();
		}

		/// <summary>
		/// Cabeçalho do programa;
		/// </summary>
		public static void Cabecalho()
		{
			Console.WriteLine("  --------------------------------------------------------------------------------------------------------  " +
						"\n |                                                                                                        | " +
						"\n |                                 PROGRAMA VERIFICADOR DE IDADE                                          | " +
						"\n |                                                                                                        | " +
						"\n  --------------------------------------------------------------------------------------------------------  ");
		}

		public static void CapturaInformacoes()
		{
			Cabecalho();

			Console.Write("Digite o nome: ");
			string nomeInformado = Console.ReadLine();

			Console.WriteLine("Digite sua idade: ");
			int.TryParse(Console.ReadLine(), out int idade);
			
			if (idade > 18)
				Console.WriteLine($"Bora beber {nomeInformado} sextou!!!");
			else
				Console.WriteLine("Espera fazer 18 BB");

			Console.ReadKey();
			
			//long.TryParse(dataNascimentoInformada, out long dataInformada);
			//CalculaIdade(dataNascimentoInformada);

			//long datanascimento = (Convert.ToDateTime(dataNascimentoInformada).Year + Convert.ToDateTime(dataNascimentoInformada).Month +
			//	+ Convert.ToDateTime(dataNascimentoInformada).Day);
			//
			//long.TryParse(DateTime.Now.ToString("yyyyMMdd"), out long dataAtual);
			//
			//long resultadoData = datanascimento - dataAtual;
			//Console.WriteLine(resultadoData);

		}
		//public static void CalculaIdade(string dataNascimentoInformada)
		//{
		//	int.TryParse(DateTime.Now.ToString("yyyy"), out int dataAtual);
		//	string anoNascimento;
		//	for (int i = 6; i < dataNascimentoInformada.Length; i++)
		//	{
		//		anoNascimento = dataNascimentoInformada[i];
		//		//anoNascimento += dataNascimentoInformada[i];
		//	}
		//}

	}
}


