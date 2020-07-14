using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Fish is a child class of animal and the parent of Shark and Salmon
    /// </summary>
    public abstract class Fish : Animal
    {
        decimal AverageSwimSpeed { get;  set; }
        int NumberOfFins { get;  set; }

        /// <summary>
        /// All fish swim. This is the method for all fish
        /// </summary>
        /// <returns>Returns string message</returns>
        public string IsSwimming()
        {
            string message = $"{Name} is swimming so far!";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Describes whether the fish is a fresh water fish or a salt water fish.
        /// </summary>
        /// <returns>Returns a string.</returns>
        public abstract string FreshOrSalt();
    }
}
