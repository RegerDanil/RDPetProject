using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class BrewingUnit
    {
        public Coffee GetBrew(GroundCoffee groundCoffee)
        {
            Coffee coffee = new Coffee();
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Кофе варится!");
            return coffee;
        }
    }
}
