using DecoratorDesignPattern.Starbuzz.Operations.Base;

namespace DecoratorDesignPattern.Starbuzz.Operations.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }
        public override double Cost()
        {
            return 20.89;
        }
    }
}
