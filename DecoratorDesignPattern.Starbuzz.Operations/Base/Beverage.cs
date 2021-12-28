namespace DecoratorDesignPattern.Starbuzz.Operations.Base
{
    public abstract class Beverage
    {
        public string description = "";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();

    }
}
