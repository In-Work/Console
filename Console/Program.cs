using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut donut = new Donut("Cухарик", 25, false);
            donut.Print();
            System.Console.ReadLine();
        }
    }
}
