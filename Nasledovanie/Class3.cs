using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    class Car : Transport // Car -дочерний класс, Transport - класс родитель
    {
        public double Speed { get; set; }
        //наследование полей родителя 
        public Car(int year, int weight, string color, double speed) : base(year, weight, color)
        {
            Speed = speed;
        }
        public override void Info() //переопределение метода Info метода класса родителя
        {
            Console.WriteLine("Car");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Weight: {Weight}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"Speed: {Speed:0.00}\n");
        }
    }
}
