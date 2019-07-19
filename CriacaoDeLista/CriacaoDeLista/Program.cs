using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
	class Program
	{
		static void Main(string[] args)
		{	
			//Iniciando lista
			string[] lista = new string[10]; //definindo as posições da lista iniciando-a com 10
			//espaços na memoria para alocar informações de texto

			//laço que usamos geralmente para andar sobre as posições da nossa lista
			for (int i = 0; i < lista.Length; i++)
			{
				//carregando os valores da nossa lista aqui
				//ainda "i" representa cada espaço disponivel
				lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
				//DateTime e um tipo do .net C# que disponibiliza funções relacionadas a datas
				//horas, ou seja se precisar trabalhar com essas informações é possivel usar esse cara
			}
			//Laço de repetição que usamos para varrer nossa lista de maneiras mais simples
			foreach (var item in lista) //"var item" indica unidade da lista "in lista"
				//indica a lista que desejamos varrer
				Console.WriteLine(item); // nostra inf. na tela

			Console.ReadKey(); // impede que o console feche no fim da aplicação


			for (int i = 0; i < lista.Length; i++)
				lista[i] = string.Empty; // limpa os valores dentro da coleção

			//Laço de repetição que usamos para varrer nossa lista de maneira mais simples 
			foreach (var item in lista) //"var item" indica unidade da lista "in lista"
				//indica a lista que desejamos varrer
				Console.WriteLine(item);// "Apresenta" informações na tela

			Console.ReadKey();
		}
	}
}
