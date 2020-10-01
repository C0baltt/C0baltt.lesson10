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


    }
}
