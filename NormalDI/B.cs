using System;

namespace NormalDI
{
    public class B : BBase
    {
        private readonly WidgetFactoryBase _widgetFactory;
        public B(WidgetFactoryBase widgetFactory, string whatYouWantFromB):base(whatYouWantFromB)
        {
            _widgetFactory = widgetFactory;
        }

        public override Widget CreateWidget(string name, Guid id)
        {
            return _widgetFactory.CreateWidget(name, id);
        }
    }
}
