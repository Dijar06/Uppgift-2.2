using System;

namespace Uppgift2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i längdhopp?");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i längdhopp?");
            float y = float.Parse(Console.ReadLine());
            float z = x - y;
            Console.WriteLine("Elin hoppade " + z + " meter längre än Alma");
        }
    }
}