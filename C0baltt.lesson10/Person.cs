using System;
using System.Dynamic;

namespace C0baltt.lesson10
{
    public class Person//инициализируем класс Person
    {
        public string SecondName { get; set; }//задаем свойства 

        public string Name { get; set; }//задаем свойства 

        public int X { get; set; }

        public int Y { get; set; }

        public Person(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;

            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd1 = new Random();

            X += rnd1.Next(-7, 7);

            //var rnd2 = new Random();

            Y += rnd1.Next(-7, 7);

            return $"{Name} ({X}, {Y})";
        }


    }
}
