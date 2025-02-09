 	using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		 
			int[] valores = new int[5];
				
			Console.WriteLine("Digite 5 valores para o vetor: ");
			Console.WriteLine();
			
			for (int i = 0; i < valores.Length; i++)
			{	
					Console.Write("Valor {0}: ", i+1);
				valores[i] = int.Parse(Console.ReadLine());
			}
			
			Array.Sort(valores);
			Array.Reverse(valores);
			
			Console.WriteLine("\n\rValores em ordem descrecente: ");
			Console.WriteLine(string.Join(", ", valores));
			
			Console.WriteLine();
			Console.WriteLine("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
