using System;

namespace GrupaB
{
	class Program
	{
		static void Main(string[] args)
		{
			int broj = 27;

			while (broj > 1)
			{
				Console.WriteLine(broj);
				if (broj % 2 == 0)
				{
					broj = broj / 2;
				} else
				{
					broj = broj * 3 + 1;
				}	
			}
			Console.WriteLine(broj);
		}
	}
}
