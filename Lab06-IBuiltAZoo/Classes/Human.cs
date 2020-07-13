using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Human class is a child of Mammals who is a child of Animals
    /// </summary>
    public class Human : Mammals
    {
        string Language { get; set; }
        decimal Height { get; set; }

        /// <summary>
        /// Constructor method for the human class
        /// </summary>
        /// <param name="name">Takes in a string for the name</param>
        public Human(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The human talks
        /// </summary>
        /// <returns>Returns a string message</returns>
        public string IsTalking()
        {
            string message = $"{Name} is talking.";
            Console.WriteLine(message);
            return message;
        }
    }
}
