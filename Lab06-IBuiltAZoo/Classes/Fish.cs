using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public abstract class Fish :Animal
    {
        decimal AverageSwimSpeed { get;  set; }
        int NumberOfFins { get;  set; }

        public string IsSwimming()
        {
            string message = $"{Name} is swimming so far!";
            Console.WriteLine(message);
            return message;
        }
    }
}
