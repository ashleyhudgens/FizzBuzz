using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintNumbers print = new PrintNumbers();

            var blah = args[0];
            var blahblah = args[1];

            var x = Convert.ToInt32(blah);
            var y = Convert.ToInt32(blahblah);

            print.printRangeOfNumbers(x, y);

            Console.ReadLine();

        }
    }
}
