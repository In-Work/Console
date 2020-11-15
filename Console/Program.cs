using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Donut> donuts = new List<Donut> { 
                new Donut("Cухарик", 25, false),
                new Donut("Здоровяк", 2000, true),
                new Donut("Нежданчик", 150, true) 
            };
            foreach (var item in donuts)
            {
                item.Print();
            }
            System.Console.ReadLine();
        }
    }
}
