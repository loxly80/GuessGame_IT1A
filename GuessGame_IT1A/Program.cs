using System;

namespace GuessGame_IT1A
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nahodneCislo;
            nahodneCislo = random.Next(1, 100);
        
            Console.WriteLine(" Hádací hra");
            Console.WriteLine("------------------");
            Console.WriteLine(" Myslím si číslo od 1 do 100");



            Console.ReadLine();                        
        }
    }
}
