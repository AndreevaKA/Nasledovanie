using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public abstract class Transport
    {
        //базовый класс транспорт, от которого юудет наследование
        public int Year { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        protected Transport() { }

        protected Transport(int year, int weight, string color)
        {//конструктор с параметрами
            Year = year;
            Weight = weight;
            Color = color;
        }

        public abstract void Info();


    }
}
