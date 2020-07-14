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
        // This overrides the MaxSpeed from the Animal abstract class
        public override decimal MaxSpeed { get; set; }
        // This overrides the Name from the Animal abstract class
        public override string Name { get; set; }

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

        /// <summary>
        /// Describes shark procreation. This method overrides the abstract method
        /// from the Animal class.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string FormOfProcreation()
        {
            string message = $"Lays one egg that hatches inside the mother.";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Describes whether the shark is a fresh water fish or a salt water fish.
        /// </summary>
        /// <returns>Returns a string.</returns>
        public override string FreshOrSalt()
        {
            string message = "I am a salt water fish!";
            Console.WriteLine(message);
            return message;
        }
    }
}
