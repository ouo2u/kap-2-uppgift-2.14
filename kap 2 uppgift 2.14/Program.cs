using System;

namespace kap_2_uppgift_2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett tal med en decmial");
           double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett tal med en decmial till");
          double tal2 = double.Parse(Console.ReadLine());

            double produkt = tal1 * tal2;
            Console.WriteLine("summan av tallerna är " + produkt);


        }
    }
}
