namespace NormalDI
{
    public class ScreenFactory : ScreenFactoryBase
    {
        protected readonly ElementFactoryBase ElementFactory;
        public ScreenFactory(ElementFactoryBase elementFactory)
        {
            ElementFactory = elementFactory;
        }

        public override ScreenBase CreateScreen(string screenName)
        {
            return new Screen(ElementFactory, screenName);
        }
    }
}
