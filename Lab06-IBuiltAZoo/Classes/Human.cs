using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Human class is a child of Mammals who is a child of Animals
    /// </summary>
    public class Human : Mammals
    {
        // This overrides the name from the Animal abstract class.
        public override string Name { get; set; }
        private string Language { get; set; }
        private decimal Height { get; set; }
        // overridden property from the Animal abstract class
        public override decimal MaxSpeed { get; set; }
        // overridden property from the Mammals abstract class
        public override string HairColor { get; set; }


        /// <summary>
        /// Constructor method for the human class
        /// </summary>
        /// <param name="name">Takes in a string for the name</param>
        public Human(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The human talks
        /// </summary>
        /// <returns>Returns a string message</returns>
        public string IsTalking()
        {
            string message = $"{Name} is talking.";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Describes human procreation. This method overrides the abstract method
        /// from the Animal class.
        /// </summary>
        /// <returns>Returns a string.</returns>
        public override string FormOfProcreation()
        {
            string message = $"One live birth at a time every nine months.";
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Proclaims the leadership of the house from the virtual method declared in Mammals.
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string LeadingTheHouse()
        {            
            string message = "I think I am the leader of the house!";
            Console.WriteLine(message);
            return message;
        }
    }
}
