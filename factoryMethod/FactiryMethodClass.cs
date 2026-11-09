using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal abstract class FactoryMethodClass
    {
        public abstract List<Dish> CreateDish();
    }
}
