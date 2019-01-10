using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class PrintNumbers
    {
        public void printRangeOfNumbers(int x, int y)
        {

            for (int z = x; z <= y; z++)
            {
                printRangeOfNumbersWithThreeFiveReplaced(z);
            }
        }

        public void printRangeOfNumbersWithThreeFiveReplaced(int z)
        {
            if (z % 3 == 0 && z % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (z % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (z % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(z);
            }
        
        }
    }
}
