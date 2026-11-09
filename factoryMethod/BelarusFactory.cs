using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal class BelarusFactory : FactoryMethodClass
    {
        public override List<Dish> CreateDish()
        {
            List<Dish> dishes = new List<Dish>();
            dishes.Add(new Draniki(0.2));
            dishes.Add(new BorshPoBelarus(0.3));

            return dishes;
        }
    }
}
