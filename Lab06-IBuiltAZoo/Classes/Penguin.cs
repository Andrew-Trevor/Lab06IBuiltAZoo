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
        // This overrides the name from the Animal abstract class.
        public override string Name { get; set; }
        string WhichArctic { get;  set; }
        // This overrides the AverageWingSpan from the Birds abstract class
        public override decimal AverageWingSpan { get; set; }
        // This overrides the MaxSpeed from the Animal abstract class
        public override decimal MaxSpeed { get; set; }

        /// <summary>
        /// Constructor method of for the Penguin class
        /// </summary>
        /// <param name="name">takes in a string</param>
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

        /// <summary>
        /// Describes penguin procreation. This method overrides the abstract method
        /// from the Animal class.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string FormOfProcreation()
        {
            string message = $"Lays one egg per year.";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// This is a overridden method that says that how this bird is moving.
        /// This is overridden from the Bird abstract class.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string Moving()
        {
            string message = $"I am swimming like a fish!";
            Console.WriteLine(message);
            return message;
        }
    }
}
