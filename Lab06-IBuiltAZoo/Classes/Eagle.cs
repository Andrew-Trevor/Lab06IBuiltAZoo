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
        // This overrides the AverageWingSpan from the Birds abstract class
        public override decimal AverageWingSpan { get; set; }
        public override decimal MaxSpeed { get; set; }

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

        /// <summary>
        /// Describes eagle procreation. This method overrides the abstract method
        /// from the Animal class.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string FormOfProcreation()
        {
            string message = $"Lays one to three eggs three times a year.";
            Console.WriteLine(message);
            return message;
        }
    }
}
