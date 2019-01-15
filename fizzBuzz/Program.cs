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

            var firstNumber = args[0];
            var secondNumber = args[1];

            var x = Convert.ToInt32(firstNumber);
            var y = Convert.ToInt32(secondNumber);

            print.getPrintClass(x, y);

            Console.ReadLine();

        }
    }
}
