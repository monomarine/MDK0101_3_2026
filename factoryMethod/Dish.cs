using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal abstract class Dish
    {
        public string Title { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }

        abstract public void Prepare();
    }
}
