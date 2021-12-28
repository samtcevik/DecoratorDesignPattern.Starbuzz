using DecoratorDesignPattern.Starbuzz.Operations.Base;

namespace DecoratorDesignPattern.Starbuzz.Operations.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            description = _beverage.GetDescription();
        }
        public override string GetDescription()
        {
            return description + ", Mocha";
        }

        public override double Cost()
        {
            return 7.20 + _beverage.Cost();
        }
    }
}
