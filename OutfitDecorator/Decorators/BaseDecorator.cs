namespace OutfitDecorator.Decorators
{
    /// <summary>
    /// базовый декоратор: хранит оборачиваемый объект и по умолчанию делегирует ему вызовы
    /// </summary>
    internal abstract class BaseDecorator : IOutfit
    {
        protected readonly IOutfit _outfit;

        protected BaseDecorator(IOutfit outfit)
        {
            _outfit = outfit;
        }

        public virtual decimal GetPrice()
        {
            return _outfit.GetPrice();
        }

        public virtual string GetDescription()
        {
            return _outfit.GetDescription();
        }
    }
}
