using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Mammals is the child of Animal class and the parent of Cats and Humans
    /// </summary>
    public abstract class Mammals : Animal
    {
        string HairColor { get; set; }
        int NumberOfLimbs { get; set; }
       
        /// <summary>
        /// Mammals Run
        /// </summary>
        /// <returns>Returns a string message</returns>
        public string IsRunning()
        {
            string message = $"{Name} is running";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Is the mammal sleeping
        /// </summary>
        /// <returns>Returns the boolean true</returns>
        public bool Sleep()
        {
            Console.WriteLine($"{Name} is asleep.");
            return true;
        }
    }
}
