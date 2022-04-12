using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenOrOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even:" + num);

            }
            else
                Console.WriteLine("The number is odd:" +num);
        }
    }
}
