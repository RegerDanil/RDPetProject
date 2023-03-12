using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    enum RecipeName { Латте = 1, Капучино = 2, Эспрессо = 3 }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            int f = 0;
           
            int _value;
            
              
             
            while (f != 7)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Меню кофемашины:");
                    Console.WriteLine("1-Добавить молоко в контейнер");
                    Console.WriteLine("2-Добавить воду в контейнер");
                    Console.WriteLine("3-Добавить кофейные зерна в контейнер");
                    Console.WriteLine("4-Сварить латте");
                    Console.WriteLine("5-Сварить капучино");
                    Console.WriteLine("6-Сварить эспрессо");
                    Console.WriteLine("7-Выход из программы");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string('*', 79));
                    var a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(new string('*', 79));
                    switch (a)
                    {
                        case 1:
                            {
                                coffeeMachine.LoadMilk(value: 0);
                                int value = Convert.ToInt32(Console.ReadLine());
                                Container.LoadResource(value);
                                Container container = new Container(value);
                                Console.WriteLine($"Продукта {_value} из {_capacity}");
                                Console.WriteLine("Сколько добавить?");
                                break;
                            }
                        case 2:
                            {
                                coffeeMachine.LoadWater(value: 0);
                                int value = Convert.ToInt32(Console.ReadLine());
                                Container container = new Container(value);
                                Console.WriteLine($"Продукта {_value} из {_capacity}");
                                Console.WriteLine("Сколько добавить?");
                                break;
                            }
                        case 3:
                            {
                                coffeeMachine.LoadBeans(value: 0);
                                int value = Convert.ToInt32(Console.ReadLine());
                                Container container = new Container(value);
                                Console.WriteLine($"Продукта {_value} из {_capacity}");
                                Console.WriteLine("Сколько добавить?");
                                break;
                            }
                        case 4:
                            {
                                coffeeMachine.Brew(RecipeName.Латте); 
                                break;
                            }
                        case 5:
                            {
                                coffeeMachine.Brew(RecipeName.Капучино); 
                                break;
                            }
                        case 6:
                            {
                                coffeeMachine.Brew(RecipeName.Эспрессо); 
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Вышел");
                                f = 7;
                                break;
                            }
                    }
                }
                catch (MyException my) { Console.WriteLine(my.Message); }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(new string('*', 79));
            }
         
            Console.ReadKey();
        }
    }
}
