namespace OutfitDecorator.Decorators
{
    internal class ShoesDecorator : BaseDecorator
    {
        public ShoesDecorator(IOutfit outfit) : base(outfit)
        {
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 4000;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", кроссовки";
        }
    }
}
