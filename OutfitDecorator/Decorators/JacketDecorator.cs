namespace OutfitDecorator.Decorators
{
    internal class JacketDecorator : BaseDecorator
    {
        public JacketDecorator(IOutfit outfit) : base(outfit)
        {
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 5000;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", куртка";
        }
    }
}
