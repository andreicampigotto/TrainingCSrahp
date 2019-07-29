using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
	class Conta
	{
		double saldo = 0;

		//Propriedade que contem o valor de saldo
		public double Saldo { get { return saldo; } }

		public Conta()
		{
			//Bonus de mil reais para iniciar operar daytrade
			saldo = 1000;
		}

		/// <summary>
		/// Método para sacar de acordo com o saldo disponivel
		/// </summary>
		/// <param name="valor">Valor para sacar</param>
		/// <returns>retorna se o saque foi feito ou não</returns>
		public bool Sacar(double valor)
		{

			if (valor <= saldo)
			{// Desconta do valor do saldo na conta
				saldo -= valor;
				return true;
			}
			//retorna false em caso de não conter saldo disponivel
			return false;	
		}
		
		/// <summary>
		/// Metodo que mostra saldo em conta
		/// </summary>
		public double MostraSaldo()
		{
			return saldo;
		}
	}
}
