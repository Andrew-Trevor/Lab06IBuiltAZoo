using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public class Shark : Fish
    {
        int RowsOfTeeth { get; set; }
        bool Carnivor { get;  set; }

        public Shark(string name)
        {
            Name = name;
        }

        public bool SmellBlood()
        {
            Console.WriteLine($"{Name} can smell blood.");
            return true;
        }
    }
}
