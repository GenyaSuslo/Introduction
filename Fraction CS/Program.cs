//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORS_CHECK
            Fraction_CS A = new Fraction_CS();
            //A.setDenominator(44);//этот вывод сделан через стандартные get/set методы
            //A.setInteger(22);
            //A.setNumerator(33);
            //A.Print();
            A.Integer = 123;
            A.Numerator = 456;
            A.Denominator = 789;
            Console.WriteLine(A);

            Console.WriteLine(A.GetType());//по умолчанию выводит GetType, возвращает тип данных
            //что бы видеть значения строки 80-92 в fraction
            Console.WriteLine(A);
            Fraction_CS B = new Fraction_CS(5);
            B.Print();
            Console.WriteLine(B);

            Fraction_CS C = new Fraction_CS(2, 3);
            C.Print();
            Console.WriteLine(C);

            Fraction_CS D = new Fraction_CS(2, 3, 4);
            D.Print();
            Console.WriteLine(D);

            Fraction_CS E = new Fraction_CS(D);
            Console.WriteLine(E); 
#endif
            Fraction_CS A = new Fraction_CS(2, 3, 4);
            Fraction_CS B = new Fraction_CS(3, 4, 5);
            Fraction_CS C = A / B;
            Console.WriteLine($"{A}/{B} = {C}");
        }
        
    }
}
