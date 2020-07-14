using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Child of Mammals who is a child of Animal
    /// </summary>
    public class Cat : Mammals
    {
        // This overrides the name from the Animal abstract class.
        public override string Name { get; set; }
        float Cuteness { get; set; }
        string Breed { get; set; }
        // This overrides the MaxSpeed from the Animal abstract class.
        public override decimal MaxSpeed { get; set; }
        // This overrides the HairColor from the Mammals abstract class.
        public override string HairColor { get; set; }

        /// <summary>
        /// Constructor method for Cat
        /// </summary>
        /// <param name="name">Takes in a string for the name</param>
        public Cat(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The cat is meowing
        /// </summary>
        /// <returns>Returns a string message from the cat</returns>
        public string IsMeowing() 
        {
            string message = $"{Name} says Roar!!!";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Describes cat procreation. This method overrides the abstract method
        /// from the Animal class.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string FormOfProcreation()
        {
            string message = $"Produces a litter every birth roughly year round.";
            Console.WriteLine(message);
            return message;
        }


        /// <summary>
        /// Proclaims the leadership of the house from the virtual method declared in Mammals.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string LeadingTheHouse()
        {
            string message = "I truly am the leader of the house!";
            Console.WriteLine(message);
            return message;
        }
    }
}
