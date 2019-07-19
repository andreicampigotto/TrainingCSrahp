using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBeep
{
	static class Tetris
	{

		static void Main()
		{	
			//Aqui nesta parte ele pega a hora e minutos
			var dateVerify = DateTime.Now.ToString("HH:mm");

			Console.WriteLine("informe sua fileira");
			//Pede a informação da fileira que ele irá executar
			var fileira = Console.ReadLine();//Pega o número digitado

			Console.WriteLine("Informe a hora de inicio no formato HH:mm");
			//Estamos assinando a variavel de comparação
			var timeStart = Console.ReadLine();


			//Laço de repetição que fica rodando enquanto nõ for a hora marcada
			while (dateVerify != timeStart)
			{
				//Thread.Sleep(100);
				//Atualiza o valor da variavel "dateVerify" com hora e minutos atuais
				dateVerify = DateTime.Now.ToString("HH:mm");
			}

			//seta o tempo de incremento entre as execuções
			var startTimerIcrement = 200;

			//Pega um valor de um objeto qualuqer e cria uma lista para o mesmo e executa de acordo com a chamada
			switch (fileira)
			{
				//Cade identifica que tem que fazer uma escolha
				//em seguida ele pede o numero escolhido
				case "1": { Fileira1(startTimerIcrement); } break; 
				case "2": { Fileira2(startTimerIcrement); } break;
				case "3": { Fileira3(startTimerIcrement); } break;
				case "4": { Fileira4(startTimerIcrement); } break;
				case "5": { Fileira5(startTimerIcrement); } break;
				case "6": { Fileira6(startTimerIcrement); } break;
				case "7": { Fileira7(startTimerIcrement); } break;
				case "8": { Fileira8(startTimerIcrement); } break;
				case "9": { Fileira9(startTimerIcrement); } break;
				case "10": { Fileira10(startTimerIcrement); } break;
					//Caso não informado de 1 a 10  apresenta erro
				default: { Console.WriteLine("Não foi uma escolha valida dentro do menu de opções"); } break;
			}

			Console.ReadKey();

		}

		static void Fileira1(int thread)
		{
			Thread.Sleep(thread);
			Console.Beep(1320, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(880, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
		}
		static void Fileira2(int thread)
		{
			Thread.Sleep(thread * 2);
			Console.Beep(990, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1320, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1188, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(990, 250);
		}
		static void Fileira3(int thread)
		{
			Thread.Sleep(thread * 3);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1188, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1408, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(990, 250);
		}
		static void Fileira4(int thread)
		{
			Thread.Sleep(thread * 4);
			Console.Beep(1188, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1760, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
		}
		static void Fileira5(int thread)
		{
			Thread.Sleep(thread * 5);
			Console.Beep(1320, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(990, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1584, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1188, 250);
		}
		static void Fileira6(int thread)
		{
			Thread.Sleep(thread * 6);
			Console.Beep(1188, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1408, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1320, 250);//
		}
		static void Fileira7(int thread)
		{
			Thread.Sleep(thread * 7);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1188, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1320, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
		}
		static void Fileira8(int thread)
		{
			Thread.Sleep(thread * 8);
			Console.Beep(990, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(880, 250);
		}
		static void Fileira9(int thread)
		{
			Thread.Sleep(thread * 9);
			Console.Beep(880, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1056, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1320, 50250);
			Thread.Sleep(thread * 10);
			Console.Beep(880, 250);
		}
		static void Fileira10(int thread)
		{
			Thread.Sleep(thread * 10);
			Console.Beep(880, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(880, 250);
			Thread.Sleep(thread * 10);
			Console.Beep(1188, 250);
		}

	}

}