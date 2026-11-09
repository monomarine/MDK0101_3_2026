using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal class BorshPoBelarus : Dish
    {
        public BorshPoBelarus(double weight)
        {
            Title = "Борщ по беларусски";
            Weight = weight;
            Price = 300;
        }

        public override void Prepare()
        {
            Console.WriteLine($"{Title} - вес: {Weight}, цена: {Price}");
        }
    }
}
