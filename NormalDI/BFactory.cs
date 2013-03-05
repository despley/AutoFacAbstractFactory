namespace NormalDI
{
    public class BFactory : BFactoryBase
    {
        private readonly WidgetFactoryBase _widgetFactory;
        public BFactory(WidgetFactoryBase widgetFactory)
        {
            _widgetFactory = widgetFactory;
        }

        public override BBase CreateB(string whatYouWantFromB)
        {
            return new B(_widgetFactory, whatYouWantFromB);
        }
    }
}
