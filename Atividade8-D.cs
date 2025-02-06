using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{				
			int soma = 0;
			
			Console.WriteLine("Digite um número: ");
			var numero = int.Parse(Console.ReadLine());
			Console.WriteLine( );
			
			for (int contador = 0; 	contador < numero; contador++){			
				soma += contador;
			}
	
			Console.WriteLine("\n\rA soma dos números é {0}", soma);
			Console.WriteLine("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
