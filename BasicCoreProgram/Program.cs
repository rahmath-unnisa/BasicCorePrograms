using System;
namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. Leap Year \n3. Power Of Two \n4. Harmonic Number \n5. Prime Factor \n6.Quotient And Reminder \n7. End the Program");
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
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.year();
                        break;
                    case 3:
                        PowerOf2 Power = new PowerOf2();
                        Power.TwoPower();
                        break;
                    case 4:
                        HarmonicNumber number = new HarmonicNumber();
                        number.harmonic();
                        break;
                    case 5:
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.factor();
                        break;
                    case 6:
                        QuotientReminder quotientReminder = new QuotientReminder();
                        quotientReminder.qrprogram();
                        break;
                   
                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;

                }


            }

        }
        

        
    } 
}