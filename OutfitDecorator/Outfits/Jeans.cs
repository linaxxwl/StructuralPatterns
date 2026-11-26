namespace OutfitDecorator.Outfits
{
    internal class Jeans : IOutfit
    {
        public decimal GetPrice()
        {
            return 3000;
        }

        public string GetDescription()
        {
            return "Джинсы";
        }
    }
}
