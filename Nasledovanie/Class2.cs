using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    class Train : Transport
    {

        public int Сarriages { get; set; }
        public Train(int year, int weight, string color, int carriages) : base(year, weight, color)
        {
            Сarriages = carriages;
        }
        public override void Info()
        {
            Console.WriteLine("Train");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Weight: {Weight}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"Сarriages: {Сarriages}\n");
        }
    }
}
