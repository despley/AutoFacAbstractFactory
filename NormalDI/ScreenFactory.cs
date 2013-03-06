namespace NormalDI
{
    public class ScreenFactory : ScreenFactoryBase
    {
        private readonly ElementFactoryBase _elementFactory;
        public ScreenFactory(ElementFactoryBase elementFactory)
        {
            _elementFactory = elementFactory;
        }

        public override ScreenBase CreateScreen(string screenName)
        {
            return new Screen(_elementFactory, screenName);
        }
    }
}
