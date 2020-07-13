using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Child class of Birds who is a child of Animal
    /// </summary>
    public class Eagle : Birds
    {
        string EagleSpecie { get; set; }

        /// <summary>
        /// Constructor method of Eagle
        /// </summary>
        /// <param name="name">Take in a string for a name</param>
        public Eagle(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The eagle is flying
        /// </summary>
        /// <returns>Return a string Message</returns>
        public string IsFlying()
        {
            string message = $"{Name} is flying so high";
            Console.WriteLine(message);
            return message;
        }
    }
}
