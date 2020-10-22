using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AufgabeLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aufgabe Lottery!");

            Random random = new Random();

            string lotteryNumber = "";

            for (int i = 0; i < 6; i++)
            {
                lotteryNumber += random.Next(0, 10);
                // Console.WriteLine(lotteryNumber);
            }

            Console.WriteLine("Lottery Zahl: " + lotteryNumber);

            Boolean isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Bitte geben Sie ihren Tipp ein:");
                string input = Console.ReadLine();

                int test;

                if (input.Length != 6)
                {
                    Console.WriteLine("Ihre Eingabe ist falsch.");
                }
                else
                {

                    string printString = "";

                    for (int i = 0; i < 6; i++)
                    {
                        if (lotteryNumber.Substring(i, 1) == input.Substring(i, 1))
                        {
                            printString += lotteryNumber.Substring(i, 1);
                        }
                        else
                        {
                            printString += "?";
                        }
                    }

                    if (printString.Equals(lotteryNumber))
                    {
                        Console.WriteLine("RICHTIG: " + printString);
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Folgende Zahlen stimmen: " + printString);
                        Console.WriteLine("Bitte versuchen Sie es noch einmal");
                    }

                }

            }


        }
    }
}
