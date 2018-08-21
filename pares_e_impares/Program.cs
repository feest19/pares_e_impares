using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_e_impares
{
	class Program
	{
		static void Main(string[] args)
		{
			int val1;
			Console.WriteLine("Dame un numeros y te dire si es par o impar");
			Console.WriteLine("increse el primer numero");
			val1 = Convert.ToInt16(Console.ReadLine());

			while (val1 != 0)
			{
				if ((val1 % 2) == 0)
				{
					Console.WriteLine("el numero es par ", val1);
					Console.Write("si quiere salir del programa tipee la tecla (0) ");
					val1 = Convert.ToInt16(Console.ReadLine());
				}
				else if ((val1 % 2) != 0)
				{
					Console.WriteLine("el numero es impar ", val1);
					Console.Write("si quiere salir del programa tipee la tecla (0) ");
					val1 = Convert.ToInt16(Console.ReadLine());
				}
				else
				{
					Console.Write("entrada erronea, para segir tiene que tipear un numero o si desea canselar la tecla (0)");
					val1 = Convert.ToInt16(Console.Read());
				}
			}
		}
	}
}
