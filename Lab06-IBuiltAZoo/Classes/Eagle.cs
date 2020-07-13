using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public class Eagle : Birds
    {
        string EagleSpecie { get; set; }

        public Eagle(string name)
        {
            Name = name;
        }

        public string IsFlying()
        {
            string message = $"{Name} is flying so high";
            Console.WriteLine(message);
            return message;
        }
    }
}
