using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        const double HEAD = 0.5;
        int hCount = 0;
        int tCount = 0;
        public void flip()
        {
            for(int i = 0; i < 100; i++)
            {
                Random random = new Random();
                double num = random.NextDouble();
                if(num < HEAD)
                {
                    tCount++;
                }
                else
                {
                    hCount++;
                }
            }
            double hPercentage = hCount % 100;
            double tPercentage = tCount % 100;
            Console.WriteLine("Percentage of the head coin " + hPercentage);
            Console.WriteLine("Persentage of the tail coin " + tPercentage);
        }

    }
}
