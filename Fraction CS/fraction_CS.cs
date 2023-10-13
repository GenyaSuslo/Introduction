using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_CS
{
    internal class Fraction_CS
    {
        int integer;
        int numerator;
        int denominator;
        public int Integer
        {
            get ;
            set ;
        }
        public int Numerator
        {
            get;
            set;
        }
        public int Denominator 
        {
            get { return denominator; }//эта запись-свойство, равнозначно get/set
            set //если указан set, то get в обязательном порядке должен быть тоже указан
            {
                if (value == 0) value = 1;//фильтрация
                denominator = value;
            }
        }
        //public int getInteger()
        //{
        //    return integer;
        //}
        //public int getNumerator()
        //{
        //    return numerator;
        //}
        //public int getDenominator()
        //{
        //    return denominator;
        //}
        //public void setInteger(int integer)
        //{
        //    this.integer = integer;
        //}
        //public void setNumerator(int numerator)
        //{
        //    this.numerator = numerator;
        //}
        //public void setDenominator(int denominator)
        //{
        //    if (denominator == 0) denominator = 1;//фильтрация данных(делить на 0 нельзя)
        //    this.denominator = denominator;
        //}
        //////              Constructors:
        public Fraction_CS()
        {
            //integer = numerator = 0;
            //denominator = 1;
            Integer = Numerator = 0;
            Denominator = 1;
            Console.WriteLine($"DefaultConstructor:\t{this.GetHashCode()}");
        }
        public Fraction_CS(int integer)
        {
            //this.integer = integer;
            //this.numerator = 0;
            //this.denominator = 1;
            Integer = integer;
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"1ArgConstructor:\t{this.GetHashCode()}");
        }
        public Fraction_CS(int numerator, int denominator)
        {
            //this.integer = 0;
            //setNumerator(numerator);
            //setDenominator(denominator);
            Integer = 0;
            Numerator = numerator; ;
            Denominator = denominator;
            Console.WriteLine($"2ArgConstructor:\t{this.GetHashCode()}");
        }
        public Fraction_CS(int integer, int numerator, int denominator)
        {
            Integer = integer; 
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"Constructor:\t\t{this.GetHashCode()}");
        }
        ////                Methods:
        public void Print()
        { 
        if(Integer!=0) Console.Write(Integer);//все записи исправлены на свойства
            if (Numerator != 0)
            {
                if(Integer!=0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer!=0) Console.Write(")");
             }
            else if(Integer==0) Console.Write(0);
            Console.WriteLine();
        }
        public override string ToString()//вместо перегрузки ostream оператора из С++
        {
            string output = "";
            if (Integer != 0) output+=Integer.ToString();//все переменные заменены на свойства
            if (Numerator != 0)
            {
                if (Integer != 0) output+="(";
                output+=$"{Numerator}/{Denominator}";
                if (Integer != 0) output+=")";
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
            return output;
        }


    }
}
