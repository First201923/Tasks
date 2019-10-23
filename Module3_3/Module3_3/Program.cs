using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var enteredNumber = Console.ReadLine();
            bool isNumber = int.TryParse(enteredNumber, out int numberNum);
            int[] val = new int[numberNum + 1];

            if(isNumber)
            {
                for (int i = 0; i <= numberNum ; i++)
                {
                    if(i == 0)
                    {
                        val[i] = 0;
                        Console.Write($"{val[0]} ");
                    }
                    else if(i == 1)
                    {
                        val[i] = 1;
                        Console.Write($"{val[i]} ");
                    }
                    else
                    {
                        val[i] = val[i - 2] + val[i - 1];
                        Console.Write($"{val[i]} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("entered string is not number");
            }
            Console.ReadKey();
        }
    }
}
