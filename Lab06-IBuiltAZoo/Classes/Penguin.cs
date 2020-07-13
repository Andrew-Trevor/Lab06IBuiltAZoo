using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public class Penguin : Birds
    {
        string WhichArctic { get;  set; }

        public Penguin(string name)
        {
            Name = name;
        }

        public bool IsSwimming()
        {
            Console.WriteLine($"{Name} is swimming.");
            return true;
        }
    }
}
