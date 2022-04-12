using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelAndConsonant
    {
        char ch;
        char ch1;
        public void alphabet()
        {
            Console.WriteLine("Enter the alphabet:");
            ch = Console.ReadKey().KeyChar;
            if (ch1 == 'a' || ch1 == 'e' || ch1 == 'i' || ch1 == 'o' || ch1 == 'u') 
            {
                Console.WriteLine("The entered alphabet is vowel:" + ch1);

            }
            else
                Console.WriteLine("The entered alphabet is consonant:" + ch1);
        }
    }
}
