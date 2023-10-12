using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Exchange(int a, int b)
        {
                int buffer = a;
                a = b;
                b = buffer;
        }
    }
}
