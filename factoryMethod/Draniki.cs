using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal class Draniki : Dish
    {
        public Draniki(double weight)
        {
            Title = "Драники";
            Weight = weight;
            Price = 100;
        }
        public override void Prepare()
        {
            Console.WriteLine($"{Title} - вес: {Weight}, цена: {Price}");
        }
    }
}
