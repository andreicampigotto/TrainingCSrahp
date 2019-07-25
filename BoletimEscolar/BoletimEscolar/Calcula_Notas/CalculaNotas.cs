using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar.CalculaNotas
{
	public class CalculaNotas
	{
		public double CalculaMedia(double nota1, double nota2, double nota3)
		{
			return ((nota1 + nota2 + nota3) / 3);
		}

		public int CalculaPresencas(int quantidadeAulas, int quantidadeFaltas)
		{
			return (100 - (quantidadeFaltas * 100) / quantidadeAulas);
		}

		public void Situacao(double media, int assiduidade)
		{
			if (media > 6.99 && assiduidade >= 75)
				Console.WriteLine($"Aprovado, média: {media} , assiduidade: {assiduidade}%");
			else
				Console.WriteLine($"Reprovado, média: {media} , assiduidade: {assiduidade}%");

		}
	}
}
