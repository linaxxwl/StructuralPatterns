namespace OutfitDecorator
{
    /// <summary>
    /// клиентский код, знает только про IOutfit
    /// </summary>
    internal class OutfitShop
    {
        // одинаковый сценарий для любого образа, в том числе обёрнутого декораторами
        public void ShowOutfit(IOutfit outfit)
        {
            Console.WriteLine($"Образ: {outfit.GetDescription()}");
            Console.WriteLine($"Цена: {outfit.GetPrice()} руб.\n");
        }
    }
}
