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
        // This is one of our 2 abstract properties. This will be defined in Penguin and Eagle classes
        public abstract decimal AverageWingSpan { get;  set; }
        // These properties are accessible only to itself and it's derived classes
        protected string Species { get;  set; }
        protected bool CanFly { get;  set; }

        /// <summary>
        /// Shows that the birds are singing
        /// </summary>
        /// <returns>Boolean True</returns>
        public bool Singing()
        {
            Console.WriteLine($"{Name} is singing at the top of their lungs.");
            return true;
        }

        /// <summary>
        /// This is a virtual method that says that this bird is moving.
        /// </summary>
        /// <returns>Returns a string</returns>
        public virtual string Moving()
        {
            string message = $"I am moving!!!";
            Console.WriteLine(message);
            return message;
        }
    }
}
