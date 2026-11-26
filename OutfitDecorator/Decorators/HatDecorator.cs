namespace OutfitDecorator.Decorators
{
    internal class HatDecorator : BaseDecorator
    {
        public HatDecorator(IOutfit outfit) : base(outfit)
        {
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 800;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", шапка";
        }
    }
}
