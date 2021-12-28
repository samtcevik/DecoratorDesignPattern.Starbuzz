using System;
using System.Collections.Generic;
using System.Text;
using DecoratorDesignPattern.Starbuzz.Operations.Base;

namespace DecoratorDesignPattern.Starbuzz.Operations.Condiments
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            description = _beverage.GetDescription();
        }

        public override string GetDescription()
        {
            return description + ", Whip";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 4.50;
        }
    }
}
