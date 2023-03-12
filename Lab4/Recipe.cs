using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Recipe
    {
        public int Milk { get; set; }
        public int Water { get; set; }
        public int Beans { get; set; }

        public Recipe(int milk, int water, int beans)
        {
            Milk = milk;
            Water = water;
            Beans = beans;
        }
    }
}
