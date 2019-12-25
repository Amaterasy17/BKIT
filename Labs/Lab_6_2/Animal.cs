using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_2
{
    class Animal
    {
        public Animal()
        {
            Name = "Шарик";
            Size = 4;
        }
        public Animal(int size)
        {
            Name = "Шарик";
            Size = size;
        }
        public Animal(string name)
        {
            Name = name;
            Size = 4;
        }

        [AttributeClass("Это просто размер")]
        public int Size { get; private set; } // в условных единицах
        [AttributeClass(Description = "А это имя")]
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Keep moving");
        }
        public void Alive()
        {
            Console.WriteLine("It is alive!");
        }

    }
}
