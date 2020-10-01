using System;
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

            for (var i = 0; i < 10; i++)
            {
                var position = person1.Run();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
        //модификатор_доступа тип_возвращаемого_значения имя_метода(тип_аргумента1 имя аргумента1, тип_аргумента2 имя аргумента2)
        
    }
}
