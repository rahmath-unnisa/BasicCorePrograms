using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Swapping
    {
        int x, y, temp;
        public void swap()
        {
            
            Console.WriteLine("Enter the first number: " +x);
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: " +y);
            y = Convert.ToInt32(Console.ReadLine());
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After Swapping \n");
            Console.WriteLine("The first number is: " + x);
            Console.WriteLine("The second number is: " + y);
        }
    }
}
