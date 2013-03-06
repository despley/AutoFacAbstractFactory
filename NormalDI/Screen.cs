using System;

namespace NormalDI
{
    public class Screen : ScreenBase
    {
        private readonly ElementFactoryBase _elementFactory;
        public Screen(ElementFactoryBase elementFactory, string screenName):base(screenName)
        {
            _elementFactory = elementFactory;
        }

        public override ElementBase CreateElement(string name, Guid id)
        {
            return _elementFactory.CreateElement(name, id);
        }

        public override ElementBase CreateRadioElement(string name, Guid id)
        {
            return _elementFactory.CreateRadioElement(name, id);
        }

        public override ElementBase CreateTextElement(string name, Guid id)
        {
            return _elementFactory.CreateTextElement(name, id);
        }
    }
}
