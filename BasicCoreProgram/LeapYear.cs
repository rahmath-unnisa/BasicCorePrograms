using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public void year()
        {
             int y;
            Console.WriteLine("Enter the Year");
            y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4 == 0 && 100 != 0) ||(y % 400 ==0 ))
            {
                Console.WriteLine("{0} is a Leap Year", +y);

            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year ", +y);
            }
            Console.ReadLine();
        }
        
    }
}
