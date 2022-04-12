using System;
namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. End the Program");
            while (end)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.flip();
                        break;

                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;

                }


            }

        }
        

        
    } 
}