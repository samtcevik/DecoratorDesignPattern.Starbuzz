using System;
using DecoratorDesignPattern.Starbuzz.Operations.Base;

namespace DecoratorDesignPattern.Starbuzz.Operations.Condiments
{
    public class Soya : CondimentDecorator
    {
        private  Beverage _beverage;
        public Soya(Beverage beverage)
        {
            _beverage = beverage;
            description = _beverage.GetDescription();
        }
        public override string GetDescription()
        {
            return description + ", Soya";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 5.00; 
        }
    }
}
