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
        // Virtual property - will be overridden by derived classes.
        public virtual string HairColor { get; set; }
        // These properties are accessible only to itself and it's derived classes
        protected int NumberOfLimbs { get; set; }
       
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

        /// <summary>
        /// Proclaims the leadership of the house. This is a virtual method.
        /// </summary>
        /// <returns>Returns a string</returns>
        public virtual string LeadingTheHouse()
        {
            string message = "I am the leader of the house!";
            Console.WriteLine(message);
            return message;
        }
    }
}
