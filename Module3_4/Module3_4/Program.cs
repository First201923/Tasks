using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var number = Console.ReadLine().Replace('.', ',');
            bool isNumber = double.TryParse(number, out double numberNum);
            if (isNumber)
            {
                if (numberNum >= 0)
                {
                    string s = numberNum.ToString();
                    char[] ar = s.ToCharArray();
                    Array.Reverse(ar);
                    s = new string(ar);
                    numberNum = double.Parse(s);
                    Console.Write($"Reverse number: {numberNum}");
                }
                else
                {
                    numberNum = -numberNum;
                    string s = numberNum.ToString();
                    char[] ar = s.ToCharArray();
                    Array.Reverse(ar);
                    s = new string(ar);
                    numberNum = double.Parse(s);
                    Console.Write($"Reverse number: {-numberNum}");
                }
            }
            else
            {
                Console.WriteLine("Entered string is not a number");
            }
            Console.ReadKey();
        }
    }
}
