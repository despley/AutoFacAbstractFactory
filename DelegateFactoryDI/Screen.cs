using System;

namespace DelegateFactoryDI
{
    public class Screen : ScreenBase
    {
        public delegate Screen Factory(string whatYouWantFromB);
        private readonly Element.Factory _widgetFactory;
        public Screen(Element.Factory widgetFactory, string whatYouWantFromB):base(whatYouWantFromB)
        {
            _widgetFactory = widgetFactory;
        }

        public override Element CreateWidget(string name, Guid id)
        {
            return _widgetFactory(name, id);
        }
    }
}
