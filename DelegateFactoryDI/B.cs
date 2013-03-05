using System;

namespace DelegateFactoryDI
{
    public class B : BBase
    {
        public delegate B Factory(string whatYouWantFromB);
        private readonly Widget.Factory _widgetFactory;
        public B(Widget.Factory widgetFactory, string whatYouWantFromB):base(whatYouWantFromB)
        {
            _widgetFactory = widgetFactory;
        }

        public override Widget CreateWidget(string name, Guid id)
        {
            return _widgetFactory(name, id);
        }
    }
}
