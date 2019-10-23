using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var numberString = Console.ReadLine().Replace('.', ',');
            Console.Write("Enter delete numeral:");
            var numeralString = Console.ReadLine();
            bool isNumber = int.TryParse(numberString, out int numberNum);
            bool isNumeral = int.TryParse(numeralString, out int numeralNum);
            if(isNumber && isNumeral)
            {
                if(numeralNum >= 0)
                {
                    if(numberNum >= 0)
                    {
                        char[] numberArray = numberString.ToCharArray();
                        for (int i = 0; i < numberArray.Length; i++)
                        {
                            Console.WriteLine(numberArray[i]);
                            if (numeralNum == numberArray[i])
                            {
                                Console.WriteLine("dwad");
                                numberString.Remove(i, 1);
                            }
                        }
                        Console.WriteLine(numberString);


                    }
                }
            }
            else
            {
                Console.WriteLine("Entered strings are not numbers");
            }
            Console.ReadKey();
        }
    }
}
