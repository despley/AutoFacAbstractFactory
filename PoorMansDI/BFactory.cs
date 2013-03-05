using PoorMansDI;

namespace DemoOfCreatingObjectsAtLowerLevels
{
    public class BFactory
    {
        private WidgetFactory _widgetFactory;
        public BFactory(WidgetFactory widgetFactory)
        {
            _widgetFactory = widgetFactory;
        }

        public B CreateB()
        {
            return new B(_widgetFactory);
        }
    }
}
