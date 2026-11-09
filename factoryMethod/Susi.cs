using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal class Susi : Dish
    {
        public Susi(double weight)
        {
            Title = "Суши";
            Price = 1000;
            Weight = weight;
        }
        public override void Prepare()
        {
            Console.WriteLine($"{Title} - вес: {Weight}, цена: {Price}");
        }
    }
}
