using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethod
{
    internal class Cafe
    {
        private readonly FactoryMethodClass _factoryMethod;
        private List<Dish> dishes;
        public Cafe(FactoryMethodClass fact)
        {
            _factoryMethod = fact;
            dishes = _factoryMethod.CreateDish();
        }


        public void PrintCheck()
        {
            decimal totalAmount = 0;
            StringBuilder result = new StringBuilder("Сумма по чеку:\n" +
                "------------------------\n");
            foreach(var d in dishes)
            {
                result.Append($"\n{d.Title}: {d.Weight:f2} кг - {d.Price} руб. за кг.");
                totalAmount += (decimal)d.Weight * d.Price;
            }

            result.Append($"\n--------------------------\n" +
                $"Итоговая сумма {totalAmount}");

            Console.WriteLine(result);
        }
    }
}
