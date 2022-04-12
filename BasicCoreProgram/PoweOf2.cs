using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PowerOf2
    {
        public void TwoPower()
        {
            Console.WriteLine("Enter the power value");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2" + "" + "^" + "" + i + "" + "=" + "" + Math.Pow(2, i));

            }

        }
    }
}
