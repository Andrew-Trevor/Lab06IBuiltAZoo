﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_IBuiltAZoo.Classes
{
    /// <summary>
    /// This is the Parent call to all classes.
    /// </summary>
    abstract public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal AverageLifeSpan { get; set; }

        /// <summary>
        /// Returns true if animals pro creates
        /// </summary>
        /// <returns>Returns true</returns>
        public bool ProCreating()
        {
            Console.WriteLine("Yeah that is happening");
            return true;
        }
    }
}
