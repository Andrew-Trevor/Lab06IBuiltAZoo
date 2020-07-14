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
        public override decimal MaxSpeed { get; set; }

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

        /// <summary>
        /// Describes salmon procreation. This method overrides the abstract method
        /// from the Animal class.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string FormOfProcreation()
        {
            string message = $"Swims upstream lays all their eggs then dies.";
            Console.WriteLine(message);
            return message;
        }
    }
}
