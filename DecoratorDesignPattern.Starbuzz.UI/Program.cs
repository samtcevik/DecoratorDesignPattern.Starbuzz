using DecoratorDesignPattern.Starbuzz.Operations;
using System;
using DecoratorDesignPattern.Starbuzz.Operations.Base;
using DecoratorDesignPattern.Starbuzz.Operations.Beverages;
using DecoratorDesignPattern.Starbuzz.Operations.Condiments;

namespace DecoratorDesignPattern.Starbuzz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.description + " : " + espresso.Cost() + " TL");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            houseBlend = new Soya(houseBlend);
            houseBlend.GetDescription();
            Console.WriteLine(houseBlend.description + " : " + houseBlend.Cost() + " TL");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            var totalPrice = espresso.Cost() + houseBlend.Cost();
            Console.WriteLine("Total Price : " + totalPrice + " TL");

        }
    }
}
