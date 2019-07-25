using BoletimEscolar.CalculaNotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoNota
{
	class Program
	{
		static void Main(string[] args)
		{
			CalculaNotas calcula = new CalculaNotas();

			double media, n1, n2, n3;
			Console.WriteLine("Insira a primeira notas do aluno: ");
			n1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Insira a segunda notas do aluno: ");
			n2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Insira a terceira notas do aluno: ");
			n3 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine($"Média: {media = calcula.CalculaMedia(n1, n2, n3)}");	

			int assiduidade, aulas, faltas;

			Console.WriteLine("Insira a quantidade de aulas total: ");
			aulas = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Insira a quantidade de faltas do aluno: ");
			faltas = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Assiduidade: {assiduidade = calcula.CalculaPresencas(aulas, faltas)}%");

			Console.WriteLine("Situação do aluno: "); 
				calcula.Situacao(media, assiduidade);

			Console.ReadKey();
		}
	}
}
