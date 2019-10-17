using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            byte M;
            Console.Write("Введите число компаний:");
            N = Int32.Parse(Console.ReadLine());
            Console.Write("Введите % налога:");
            M = Byte.Parse(Console.ReadLine());
            int income = 230;
            float sum;
            sum = N * income * M / 100; 
            Console.WriteLine($"Суммарный налог государства:{sum}");
            Console.ReadKey();
        }
    }
}
