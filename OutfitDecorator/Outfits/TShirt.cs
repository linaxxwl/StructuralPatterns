namespace OutfitDecorator.Outfits
{
    internal class TShirt : IOutfit
    {
        public decimal GetPrice()
        {
            return 1000;
        }

        public string GetDescription()
        {
            return "Футболка";
        }
    }
}
