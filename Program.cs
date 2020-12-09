using System;
using System.Collections.Generic;

namespace TheGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze The Magic Number!");
            Console.WriteLine("==============================");
            Console.WriteLine("Teraz wylosuję magiczną liczbę z przedziału 0 - 100,\na Ty postaraj się ją odgadnąć w jak najmniejszej ilości prób.");

            Random rnd = new Random();
            int magicNumber = rnd.Next(101);
            Console.WriteLine();

            var i = 1;  

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Podaj swoją liczbę:");
                int userNumber = int.Parse(Console.ReadLine());                         
               
                if (magicNumber > userNumber)
                {
                    Console.WriteLine("Podałeś za małą liczbę. Spróbuj ponownie!");
                }
                else if (magicNumber < userNumber)
                {
                    Console.WriteLine("Podałeś za dużą liczbę. Spróbuj ponownie!");
                }
                else
                {
                    Console.WriteLine("BRAWO! Ogadłeś wylosowaną przeze mnie liczbę! Udało się w " + i + " próbie!\n====== KONIEC GRY ======");
                    
                    break;
                }
                i++;
            }
        }
    }
}