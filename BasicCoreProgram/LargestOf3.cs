using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestOf3
    {
        int n1,n2, n3;
        string result;
        public void largest()
        {
            Console.WriteLine("Enter the first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                result = "The first number is the largest among the three.\n";
            }
            else if(n2 > n1 && n2 > n3)
            {
                result = "The second number is the largest among the three.\n ";
            }
            else
            {
                result = "The third number is the largest.\n";
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
