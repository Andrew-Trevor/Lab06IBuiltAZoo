using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Shark class is the child of Fish who is the child of Animal.
    /// </summary>
    public class Shark : Fish
    {
        int RowsOfTeeth { get; set; }
        bool Carnivor { get;  set; }

        /// <summary>
        /// Constructor method of the shark class
        /// </summary>
        /// <param name="name">Take in a string for the name</param>
        public Shark(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Boolean for the shark to smell blood
        /// </summary>
        /// <returns>Returns the boolean true</returns>
        public bool SmellBlood()
        {
            Console.WriteLine($"{Name} can smell blood.");
            return true;
        }
    }
}
