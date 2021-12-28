using DecoratorDesignPattern.Starbuzz.Operations.Base;

namespace DecoratorDesignPattern.Starbuzz.Operations.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 19.99;
        }
    }
}
