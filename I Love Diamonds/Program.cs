using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Love_Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big do you want your diamond??");
            Console.WriteLine("Input a number 3 or larger that is odd");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintDiamond(input));
        }
        public static string PrintDiamond(int n)
        {
            if (n % 2 == 0 || n < 0)
                return null;

            StringBuilder result = new StringBuilder();

            var asteriskCount = 1;
            var whiteSpaceCount = n / 2;

            while (asteriskCount <= n)
            {
                for (int i = whiteSpaceCount; i > 0; i--)
                {
                    result.Append(" ");
                }
                whiteSpaceCount--;
                for (int i = 0; i < asteriskCount; i++)
                {
                    result.Append("*");
                }
                result.Append("\n");
                asteriskCount += 2;
            }
            asteriskCount -= 2;
            whiteSpaceCount = 1;
            while (asteriskCount > 2)
            {
                for (int i = whiteSpaceCount; i > 0; i--)
                {
                    result.Append(" ");
                }
                whiteSpaceCount++;
                asteriskCount -= 2;
                for (int i = asteriskCount; i >= 1; i--)
                {
                    result.Append("*");
                }
                result.Append("\n");

            }

            return result.ToString();


        }
    }
}
