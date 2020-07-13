using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public abstract class Mammals : Animal
    {
        string HairColor { get; set; }
        int NumberOfLimbs { get; set; }
       
        public string IsRunning()
        {
            string message = $"{Name} is running";
            Console.WriteLine(message);
            return message;
        }

        public bool Sleep()
        {
            Console.WriteLine($"{Name} is asleep.");
            return true;
        }
    }
}
