using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{				
			Console.WriteLine("Digite um número inteiro positivo: ");
			var numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("\n\rOs números pares entre {0} e 0 são: ", numero);
			for (int contador = 1; 	contador < numero; contador++){
		
				if (contador % 2 == 0) {
					Console.Write(contador+ " ");
				}
			
			}
			Console.WriteLine( );
			Console.WriteLine("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
