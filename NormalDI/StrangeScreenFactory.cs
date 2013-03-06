namespace NormalDI
{
    class StrangeScreenFactory : ScreenFactory
    {
        protected StrangeElementFactory StrangeElementFactory;

        public StrangeScreenFactory(ElementFactoryBase elementFactory) : base(elementFactory)
        {
        }

        public override ScreenBase CreateScreen(string screenName)
        {
            return new StrangeScreen(ElementFactory, screenName);
        }
    }
}
