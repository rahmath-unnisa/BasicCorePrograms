using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientReminder
    {
        public void qrprogram()
        {
            int x, y, r, q;
            Console.WriteLine("Enter the first number:-");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:-");
            y = Convert.ToInt32(Console.ReadLine());
            q = x / y;
            r = x % y;
            Console.WriteLine("Quotien is: " + q);
            Console.WriteLine("Reminder is: " + r);
        }
    }
}
