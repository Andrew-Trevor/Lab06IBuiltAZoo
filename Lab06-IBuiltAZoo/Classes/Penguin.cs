﻿using System;
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
        // This overrides the AverageWingSpan from the Birds abstract class
        public override decimal AverageWingSpan { get; set; }
        public override decimal MaxSpeed { get; set; }

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
    }
}
