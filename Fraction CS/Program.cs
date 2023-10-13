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
            Fraction_CS A = new Fraction_CS();
            //A.setDenominator(44);
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

            Fraction_CS D = new Fraction_CS(2, 3, 0);
            D.Print();
            Console.WriteLine(D);
        }
        
    }
}
