using System;

namespace NormalDI
{
    public class Screen : ScreenBase
    {
        internal readonly ElementFactoryBase ElementFactory;
        public Screen(ElementFactoryBase elementFactory, string screenName):base(screenName)
        {
            ElementFactory = elementFactory;
        }

        [Obsolete]
        public override ElementBase CreateElement(string name, Guid id)
        {
            return ElementFactory.CreateElement(name, id);
        }

        public override ElementBase CreateRadioElement(string name, Guid id)
        {
            return ElementFactory.CreateRadioElement(name, id);
        }

        public override ElementBase CreateTextElement(string name, Guid id)
        {
            return ElementFactory.CreateTextElement(name, id);
        }

        public override ElementBase CreateStrangeDatabaseDrivenElement(string name, Guid id)
        {
            return ElementFactory.CreateStrangeDatabaseDrivenElement(name, id);
        }
    }
}
