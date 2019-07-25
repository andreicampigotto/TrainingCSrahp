using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Biblioteca
{
	public class Calculos
	{
		public double CalculaMedia(double n1, double n2, double n3)
		{
			return ( (n1 + n2 + n3) / 3);
		}

		public int CalculaFrequencia(int AulasDadas, int QuantidadeFaltas)
		{
			return (100 - (QuantidadeFaltas * 100) / AulasDadas);
		}

		public string SituacaoAluno(double media, double frequencia)
		{
			if (media >= 7 && frequencia >= 75 )
				return $"O aluno foi aprovado média: {media}, frequencia: {frequencia}%";
			
			else
				return $"O aluno foi reprovado média: {media}, frequencia: {frequencia}%";
		}
	}
}
