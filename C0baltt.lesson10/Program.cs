﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0baltt.lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var person1 = new Person("Иванов", "Иван");
            var person2 = new Person("Петров", "Петр");

            for (var i = 1; i <= 10; i++)
            {
                Console.Write(i + ". ");
                var position1 = person1.Run();
                Console.Write(position1);
                Console.Write(" ");

                var position2 = person2.Run();
                Console.WriteLine(position2);

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadLine(); 
            /*for (byte i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Factorial(a) {i}.");

                //int a = 0;

                ulong a = Convert.ToUInt64(Console.ReadLine());//преобразование типа string в int 

                Console.WriteLine(Factorial(a));

                ulong Factorial(ulong value)
                {

                    if (value <= 1)
                    {

                        return 1;
                    }
                    else
                    {

                        return value * Factorial(value - 1);
                    }

                    //модификатор_доступа тип_возвращаемого_значения имя_метода(тип_аргумента1 имя аргумента1, тип_аргумента2 имя аргумента2)

                }
                
            }
            Console.ReadLine();*/
        }
    }


}
