//#define CONSOLE_SETTINGS
//#define CLASS_WORK
//#define HOME_WORK

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        const string delimeter = "\n---------------------------------\n";
        static void Main(string[] args)
        {
#if CONSOLE_SETTINGS
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            // Console.SetWindowPosition(10, 10);
            Console.Title = "Introduction to .NET";

            Console.Beep(370, 500);

            //int start_x = 10;
            //int start_y = 10;
            int width = 120;
            int height = 32;


            Console.SetWindowSize(width, height);   // данная настройка задает ширину строк
            Console.SetBufferSize(width, height);   //данная настройка задает колличество строк

            Console.WriteLine("Buffer weight: " + Console.BufferWidth);
            Console.WriteLine("Buffer height: " + Console.BufferHeight);
            Console.WriteLine(delimeter);
            Console.WriteLine("Window width: \t" + Console.WindowWidth);
            Console.WriteLine("Window height: \t" + Console.WindowHeight);

            Console.ResetColor();

            Console.Write("Hello .NET");
            Console.WriteLine();

            //Console.SetCursorPosition(20, 10);
            Console.CursorLeft = 50;
            Console.CursorTop = 8;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cursor position check");

            Console.SetCursorPosition(25, 7); Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;//цвет букв
            Console.WriteLine("Cursor position check2");
            Console.BackgroundColor = ConsoleColor.Black;//цвет фона
            Console.ResetColor(); 
#endif


#if CLASS_WORK
            Console.Write("Введите ваше имя:");
            string first_name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());  //convert отвечает за преобразование типов
            //1)конкатенация строк
            Console.WriteLine("Имя: " + first_name + ", фамилия: " + last_name + ", возраст: " + age + " лет");

            //2) Форматирование строк:
            Console.WriteLine(string.Format("Имя: {0}, фамилия: {1}, возраст: {2} лет", first_name, last_name, age));//функция с произвольным набором параметров

            // 3) Интерполяция строк:
            Console.WriteLine($"Имя: {first_name}, фамилия: {last_name}, возраст: {age} лет");
            Console.WriteLine($"Имя: {{first_name}}, фамилия: {{{last_name}}}, возраст: {age} лет"); 
#endif

#if HOME_WORK
            Console.WriteLine("Для выхода наберите 'e'\n");
            Console.WriteLine("Для для движения вперед 'w'\n");
            Console.WriteLine("Для для движения назад 's'\n");
            Console.WriteLine("Для для движения влево 'a'\n");
            Console.WriteLine("Для для движения вправо 'd'\n");
            Console.WriteLine("нажмите клавишу: ");
            char key;
            do
            {
                key = Console.ReadLine()[0];
                //Console.WriteLine("Для выхода наберите 'e'\n");
                //Console.WriteLine("Для для движения вперед 'w'\n");
                //Console.WriteLine("Для для движения назад 's'\n");
                //Console.WriteLine("Для для движения влево 'a'\n");
                //Console.WriteLine("Для для движения вправо 'd'\n");
                //Console.WriteLine("нажмите клавишу: ");

                switch (key)
                {
                    case 'w':
                    case 'W':
                        Console.WriteLine("вперед");
                        break;
                    case 's':
                    case 'S':
                        Console.WriteLine("назад");
                        break;
                    case 'a':
                    case 'A':
                        Console.WriteLine("влево");
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("вправо");
                        break;
                    default:
                        Console.WriteLine("Error key");
                        break;
                }

            }
            while (key != 'e'); 
#endif


        }
    }
}
