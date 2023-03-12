using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Container
    {
        private int _value = 0;
        private int _capacity;
        public Container(int capacity) { _capacity = capacity; }

        public void LoadResource(int value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            
            if (value < 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new MyException("Неверный ввод!!!!"); 
            }
            else if (_value + value > _capacity) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _value = _capacity;
                throw new MyException("Много продуктов в контейнере!!!!");
            }
            else { _value += value; }
            Console.WriteLine($"Теперь продукта {_value} из {_capacity}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void GetResource(int value)
        {
            if (_value - value < 0) 
            { 
                Console.ForegroundColor = ConsoleColor.Red; 
                throw new MyException("Мало продуктов в контейнере!!!!"); 
            }
            else { _value -= value; }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public int GetCapacity() { return _capacity; }
        public int GetValue() { return _value; }
    }
}
