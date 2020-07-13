using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Salmon class is the child of Fish who is the child of Animal
    /// </summary>
    public class Salmon : Fish
    {
        string Species { get; set; }

        /// <summary>
        /// Constructor method of the Salmon Class
        /// </summary>
        /// <param name="name">Takes in a string for the name</param>
        public Salmon(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The salmon is swimming up stream
        /// </summary>
        /// <returns>Returns a string message</returns>
        public string SwimUpStream()
        {
            string message = $"{Name} is swimming up stream. Watch out for bears.";
            Console.WriteLine(message);
            return message;
        }
    }
}
