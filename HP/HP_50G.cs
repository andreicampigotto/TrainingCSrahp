using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50G
{
    public class HP_50G
    {
		/// <summary>
		/// Soma dos Valores
		/// </summary>
		/// <param name="valor1">primeiro valor</param>
		/// <param name="valor2">segundo valor</param>
		/// <returns>Resultado da soma</returns>
		public double Adicao(double valor1,double valor2)
		{
			return valor1 + valor2;
		}

		/// <summary>
		/// Subtrai dois valor
		/// </summary>
		/// <param name="valor1">primeiro valor</param>
		/// <param name="valor2">segundo valor</param>
		public double Subtracao(double valor1, double valor2)
		{
			return valor1 - valor2;
		}

		/// <summary>
		/// Multiplica dois valores
		/// </summary>
		/// <param name="valor1">primeiro valor</param>
		/// <param name="valor2">segundo valor</param>
		/// <returns>Retorna a Multiplicação de 2 valores</returns>
		public double Multiplicacao(double valor1, double valor2)
		{
			return valor1 * valor2;
		}

		/// <summary>
		/// Metodo de divisão de dois valores
		/// </summary>
		/// <param name="valor1">primeiro valor</param>
		/// <param name="valor2">segundo valor</param>
		/// <returns>Retorna a Divisão de dois valores</returns>
		public double Divisao(double valor1, double valor2)
		{
			return valor1 / valor2;
		}

		/// <summary>
		/// calculo  de Area do triangulo equilatero
		/// </summary>
		/// <param name="lado">passe aqui o valor do lado do seu triangulo</param>
		/// <returns> retorna a area do triangulo equilatero</returns>
		public double CalculaTrianguloEquilatero(double lado)
		{
			return (((lado * lado) * Math.Sqrt(3)) / 4);
		}

		/// <summary>
		/// Calcula a area do Retangulo
		/// </summary>
		/// <param name="b">passe aqui a base "maior lado" do seu retangulo</param>
		/// <param name="h">passe aqui a altura "menor lado" do seu retangulo</param>
		/// <returns>Retorna a area do retangulo</returns>
		public double CalculaRetangulo(double b, double h)
		{
			return (b * h);
		} 

		/// <summary>
		/// Metodo que Calcula o reio a partir da area do Circulo
		/// </summary>
		/// <param name="area">passe a area do circulo</param>
		/// <returns>retorna o raio</returns>
		public double CalculaRaio(double area)
		{
			return (Math.Sqrt(area / Math.PI));
		} 

		/// <summary>
		/// Metodo de Calculo de area do circulo
		/// </summary>
		/// <param name="raio">insira o raio do circulo</param>
		/// <returns>Retorna a are do circula</returns>
		public double CalculoAreaCirculo(double raio)
		{
			return (Math.PI * (raio * raio));
		}

		/// <summary>
		/// Metodo que calcula a area do triangulo retangulo
		/// </summary>
		/// <param name="catetoOposto"> Cateto oposto</param>
		/// <param name="catetoAdjacente"> Cateto Adjacente</param>
		/// <returns> Area do triangulo retangulo </returns>
		public double CalculoTrianguloRetangulo(double catetoOposto, double catetoAdjacente)
		{
			return ((catetoAdjacente * catetoOposto) / 2);
		}

    }
}
