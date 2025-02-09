using System;

namespace PATrilhasAtiv06
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um número inteiro positivo: ");
			var numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("\n\rEsses são seus divisores: ");
			
			for (int contador = 1; contador <= numero; contador++){
				
				if (numero % contador == 0) {
	
				Console.Write(+contador+ " ");
			}
		}
			
			Console.WriteLine();
			Console.Write("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
