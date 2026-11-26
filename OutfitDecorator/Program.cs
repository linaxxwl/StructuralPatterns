using OutfitDecorator;
using OutfitDecorator.Decorators;
using OutfitDecorator.Outfits;

internal class Program
{
    static void Main(string[] args)
    {
        // Один и тот же клиентский код OutfitShop.ShowOutfit() работает с разными комбинациями декораторов
        var shop = new OutfitShop();

        Console.WriteLine("[Футболка с шапкой]");
        IOutfit tShirtWithHat = new HatDecorator(new TShirt());
        shop.ShowOutfit(tShirtWithHat);

        Console.WriteLine("[Джинсы с курткой и кроссовками]");
        IOutfit jeansLook = new ShoesDecorator(new JacketDecorator(new Jeans()));
        shop.ShowOutfit(jeansLook);
    }
}
