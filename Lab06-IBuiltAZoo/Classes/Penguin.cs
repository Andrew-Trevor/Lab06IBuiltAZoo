using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Penguin class is the child of Birds who is the child of animals
    /// </summary>
    public class Penguin : Birds
    {
        string WhichArctic { get;  set; }

        /// <summary>
        /// Constructor method of for the Penguin class
        /// </summary>
        /// <param name="name"></param>
        public Penguin(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Penguin swims
        /// </summary>
        /// <returns>Returns a boolean true</returns>
        public bool IsSwimming()
        {
            Console.WriteLine($"{Name} is swimming.");
            return true;
        }
    }
}
