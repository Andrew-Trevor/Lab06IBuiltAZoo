using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public class Cat : Mammals
    {
        float Cuteness { get; set; }
        string Breed { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public string IsMeowing() 
        {
            string message = $"{Name} says Roar!!!";
            Console.WriteLine(message);
            return message;
        }
    }
}
