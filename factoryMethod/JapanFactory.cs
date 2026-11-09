using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal class JapanFactory : FactoryMethodClass
    {
        public override List<Dish> CreateDish()
        {
            List<Dish> dishes = new();
            int count = new Random().Next(10, 50);
            for(int i = 0; i< count; i++)
            {
                dishes.Add(new Susi(new Random().NextDouble()));
            }
            return dishes;
        }
    }
}
