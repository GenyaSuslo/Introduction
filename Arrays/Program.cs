using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static readonly string delimiter = "\n-------------------\n";
		static void Main(string[] args)
		{
			
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n]; //объявление одномерного массива
			Random rand = new Random(0);//создаем объект класса Random что бы генерировать случ. числа
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100,200);
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
            Console.WriteLine();

			foreach (int i in arr)
			{
				Console.Write(i+"\t");
			}
            Console.WriteLine();
            Console.WriteLine(delimiter);

			///////////////////////////////////////////////////////////////////////////////
			
			Console.Write("Введите количество строк: ");
			int rows=Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество элементов: ");
			int cols = Convert.ToInt32(Console.ReadLine());
			int[,] i_arr2 = new int[rows,cols];//объявление двумерного массива
			for(int i=0;i<rows;i++)
			{
				for(int j=0;j<cols;j++)
				{
					i_arr2[i, j] = rand.Next(100);
				}

			}
			for(int i=0;i<i_arr2.GetLength(0);i++)
			{
				for(int j=0;j<i_arr2.GetLength(1);j++)
				{
					Console.Write(i_arr2[i,j]+"\t");
                }
				Console.WriteLine();
			}
			Console.WriteLine("Количество измерений " + i_arr2.Rank);
            Console.WriteLine(i_arr2.GetLength(0));//количество строк
            Console.WriteLine(i_arr2.GetLength(1));//количество столбиков

			foreach(int i in i_arr2)//выводит весь массив двумерный в строку(для поиска значение и т.д.)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine(); ;
            Console.WriteLine(delimiter);

			///////////////////////////////////////////////////////////////////////////////////////

			//зубчатые массивы

			//Console.Write("Введите количество строк: ");
			//rows = Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите количество элементов: ");
			//cols = Convert.ToInt32(Console.ReadLine());

			int[][] jagged_arr = new int[][]
			{
				new int[]{ 3, 5, 8, 13, 21 },
				new int[]{ 34, 55, 89},
				new int[]{ 144, 233, 377, 510},
				arr
			};
			for(int i=0;i<jagged_arr.Length;i++)
			{
				for(int j = 0; j < jagged_arr[i].Length;j++)
				{
					Console.Write(jagged_arr[i][j] + "\t");
				}
                Console.WriteLine();
            }
		}
	}
}
