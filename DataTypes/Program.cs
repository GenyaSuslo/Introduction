//#define LOGICAL_TYPES
//#define CHARACTER_TYPES
//#define INTEGRAL_TYPES
#define FLOATING_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
	static readonly string delimiter = "\n------------------------------------------------\n";
		
		static void Main(string[] args)
        {
#if LOGICAL_TYPES

            Console.WriteLine("Bool:");
            Console.WriteLine(sizeof(bool)); //Boolean - класс обертка
            Console.WriteLine(true.GetType());//позволяет узнать какого типа будет значение
            Console.WriteLine(delimiter);
#endif

#if CHARACTER_TYPES
            Console.WriteLine("CHAR: ");//хранит 1 символ в кодировке Unicode
            Console.WriteLine(sizeof(char));
            Console.WriteLine((int)(char.MinValue));
            Console.WriteLine((int)(char.MaxValue));
            Console.WriteLine(delimiter);
#endif

#if INTEGRAL_TYPES
            Console.WriteLine("SHORT: ");
            Console.WriteLine(sizeof(short));
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine("USHORT-unsigned short:");
            Console.WriteLine(sizeof(ushort));
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(delimiter);

            Console.WriteLine("INT:");
            Console.WriteLine(sizeof(int));
            Console.WriteLine("UINT:unsigned int\t" + uint.MinValue + "..." + uint.MaxValue);
            Console.WriteLine("INT:\t" + int.MinValue + "..." + int.MaxValue);
            Console.WriteLine(delimiter);

            Console.WriteLine("LONG");
            Console.WriteLine(sizeof(long));
            Console.WriteLine("ULONG:unsigned long \t" + ulong.MinValue + "..." + ulong.MaxValue);
            Console.WriteLine("LONG: \t" + long.MinValue + "..." + long.MaxValue);
            Console.WriteLine(delimiter); 
#endif

#if FLOATING_TYPES
            Console.WriteLine("FLOAT:\t" + sizeof(float) + "bytes");
            Console.WriteLine(float.MinValue + "..." + float.MaxValue);
            Console.WriteLine(delimiter);
            Console.WriteLine("DOUBLE:\t" + sizeof(double) + "bytes");
            Console.WriteLine(double.MinValue + "..." + double.MaxValue);
            Console.WriteLine(delimiter);
            Console.WriteLine("DECIMAL: \t" + sizeof(decimal) + "bytes");
            Console.WriteLine(decimal.MinValue + "..." + decimal.MaxValue);
#endif







        }
	}
}
