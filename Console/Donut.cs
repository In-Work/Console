using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Donut
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public bool Topping { get; set; }

        public Donut() : this("Каой-то пончк") { }
        public Donut(string Name):this(Name, 150) { }
        public Donut(string Name, int Weight) : this(Name, Weight, false) { }
        public Donut(string Name, int Weight, bool Topping)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Topping = Topping;
        }

        public void Print()
        {
            string result = Topping ? "Есть" : "Нет";
            System.Console.WriteLine("Почкик:\n"+
                $"Название: {Name}\n" +
                $"Вес: {Weight} грамм\n" +
                $"Начинка: {result}");
        }
    }
}
