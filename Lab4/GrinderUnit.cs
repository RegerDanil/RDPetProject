using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class GrinderUnit
    { 
        public GroundCoffee Grind(int quantity)
        {
            GroundCoffee grondCoffee = new GroundCoffee();
            grondCoffee.Quantity = quantity * 2;
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("Зерна кофе перемалываются!");
            return grondCoffee;
        }
    }
}
