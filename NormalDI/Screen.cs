using System;

namespace NormalDI
{
    public class Screen : ScreenBase
    {
        private readonly ElementFactoryBase _elementFactory;

        public Screen(ElementFactoryBase elementFactory, string screenName) : base(screenName)
        {
            _elementFactory = elementFactory;
        }

        [Obsolete]
        public override ElementBase CreateElement(string description, Guid id)
        {
            return _elementFactory.CreateElement(description, id);
        }

        public override ElementBase CreateRadioElement(string description, Guid id)
        {
            return _elementFactory.CreateRadioElement(description, id);
        }

        public override ElementBase CreateTextElement(string description, Guid id)
        {
            return _elementFactory.CreateTextElement(description, id);
        }

        public override ElementBase CreateStrangeDatabaseDrivenElement(string description, Guid id)
        {
            return _elementFactory.CreateStrangeDatabaseDrivenElement(description, id);
        }
    }
}