#define CONVERT
//#define PRICE
//#define PRICE_2
//#define DISTANCE_PRICE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Home_work_Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
#if CONVERT
            
            Console.WriteLine("Преобразование числа в денежный формат.");
            Console.Write("Введите дробное число -> ");
            decimal value = Convert.ToDecimal(Console.ReadLine());
            //decimal dec = (value - Math.Floor(value)) * 100;
            decimal dec = (value % (int)value) * 100;
            Console.WriteLine(dec);

            Console.WriteLine($"{value}грн. - это {value}грн. {(int)dec} коп. "); 
#endif
#if PRICE
            Console.WriteLine("Вычисление стоимости покупки.");
            Console.WriteLine("Введите исходные данные: ");
            Console.Write("Цена тетради, грн.-> ");
            decimal t = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Колличество тетрадей -> ");
            decimal value_t = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Цена карандаша, грн. -> ");
            decimal p = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Колличество карандашей -> ");
            decimal value_p = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Стоимость покупки: " + (t * value_t + p * value_p)+" грн.");
#endif
#if PRICE_2
            Console.WriteLine("Вычисление стоимости покупки.");
            Console.WriteLine("Введите исходные данные: ");
            Console.Write("Цена тетради, грн.-> ");
            decimal price_t = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Цена обложки, грн. -> ");
            decimal price_o = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Колличество комплектов (шт) -> ");
            decimal value = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Стоимость покупки: " + (price_t + price_o)*value + " грн."); 
#endif
#if DISTANCE_PRICE
            Console.WriteLine("Вычисление расстояния поездки на дачу и обратно.");
            Console.Write("Расстояние до дачи (км) -> ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Расход бензина (литров на 100 км пробега) -> ");
            double expenses = Convert.ToDouble(Console.ReadLine());
            Console.Write("Цена за литр бензина (грн.) -> ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Поездка на дачу и обратно обойдется: " + (2 * distance/100 * expenses * price) + " грн."); 
#endif








        }
    }
}
