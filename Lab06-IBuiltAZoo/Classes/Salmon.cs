using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public class Salmon : Fish
    {
        string Species { get; set; }

        public string SwimUpStream()
        {
            string message = $"{Name} is swimming up stream. Watch out for bears.";
            Console.WriteLine(message);
            return message;
        }
    }
}
