namespace OutfitDecorator
{
    /// <summary>
    /// абстракция одежды
    /// </summary>
    internal interface IOutfit
    {
        decimal GetPrice();      //стоимость
        string GetDescription(); //описание
    }
}
