using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    public class Human : Mammals
    {
        string Language { get; set; }
        decimal Height { get; set; }

        public string IsTalking()
        {
            string message = $"{Name} is talking.";
            Console.WriteLine(message);
            return message;
        }
    }
}
