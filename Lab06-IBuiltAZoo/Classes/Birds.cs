using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    abstract public class Birds : Animal
    {
        decimal AverageWingSpan { get;  set; }
        string Speices { get;  set; }
        bool CanFly { get;  set; }

        public bool Singing()
        {
            Console.WriteLine($"{Name} is singing at the top of their lungs.");
            return true;
        }
    }
}
