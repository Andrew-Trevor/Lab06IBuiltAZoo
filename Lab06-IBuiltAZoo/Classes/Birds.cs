using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// Bird is the child of Animal and the parent of Human and Cat classes.
    /// </summary>
    abstract public class Birds : Animal
    {
        decimal AverageWingSpan { get;  set; }
        string Speices { get;  set; }
        bool CanFly { get;  set; }

        /// <summary>
        /// Shows that the birds are singing
        /// </summary>
        /// <returns>Boolean True</returns>
        public bool Singing()
        {
            Console.WriteLine($"{Name} is singing at the top of their lungs.");
            return true;
        }
    }
}
