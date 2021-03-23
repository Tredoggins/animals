using System;
using System.Collections;
using System.Collections.Generic;

namespace animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
        }
    }
}
