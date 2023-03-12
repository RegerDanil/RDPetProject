using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CoffeeMachine
    {
        private Container _milkContainer;
        private Container _waterContainer;
        private Container _beansContainer;
        private BrewingUnit _brewingUnit;
        private GrinderUnit _grinderUnit; 

        private Dictionary<RecipeName, Recipe> _recipe = new Dictionary<RecipeName, Recipe>();
        public CoffeeMachine()
        {
            _milkContainer = new Container(300);
            _waterContainer = new Container(150);
            _beansContainer = new Container(10);
            _grinderUnit = new GrinderUnit();
            _brewingUnit = new BrewingUnit();

            _recipe.Add(RecipeName.Латте, new Recipe(150, 60, 2));
            _recipe.Add(RecipeName.Капучино, new Recipe(100, 50, 3));
            _recipe.Add(RecipeName.Эспрессо, new Recipe(10, 30, 1));
        }

        public void LoadMilk(int value) { _milkContainer.LoadResource(value); }
        public void LoadWater(int value) { _waterContainer.LoadResource(value); }
        public void LoadBeans(int value) { _beansContainer.LoadResource(value); }
        public Coffee Brew(RecipeName recipeName)
        {
            Coffee coffee = new Coffee();
            _milkContainer.GetResource(_recipe[recipeName].Milk);
            _waterContainer.GetResource(_recipe[recipeName].Water);
            _beansContainer.GetResource(_recipe[recipeName].Beans);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{recipeName} готовится, не мешайте!!!");
            coffee = _brewingUnit.GetBrew(_grinderUnit.Grind(_recipe[recipeName].Beans));
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine($"{recipeName} готов!!!!!!!!!!");
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.White;
            return coffee;
        }
    }
}
