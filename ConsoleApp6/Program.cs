using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            SumLINQ();
            MaxLINQ();
        }
        
        //Sum() funktsioon liidab kõik numbrid listist kokku
        public static void SumLINQ()
        {
            Console.WriteLine("Summa on:");
            List<int> numbers = new List<int> { 1, 4, 5, 8, 2, 3, 6 };
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        //Max() funktsioon leiab listist suurima numbri
        public static void MaxLINQ()
        {
            Console.WriteLine("Suurim arv listist on:");
            List<int> numbers = new List<int> { 2, 11, 5, 7, 9, 1, 3 };
            int max = numbers.Max();
            Console.WriteLine(max);
        }
    }
}
