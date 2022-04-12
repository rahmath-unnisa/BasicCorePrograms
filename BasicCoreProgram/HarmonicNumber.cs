using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public void harmonic()
        {
            double result = 0.0;
            Console.WriteLine("Enter A Number:-");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                result += (double)1 / i;
                Console.WriteLine(result + " ");
            }
        }
    }
}
