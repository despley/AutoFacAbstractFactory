using System;

namespace NormalDI
{
    public class StrangeScreen : Screen
    {
        public StrangeScreen(ElementFactoryBase elementFactory, string screenName) : base(elementFactory, screenName)
        {}
        public override ElementBase CreateStrangeDatabaseDrivenElement(string name, Guid id)
        {
            return ElementFactory.CreateStrangeDatabaseDrivenElement(name, id);
        }
    }
}
