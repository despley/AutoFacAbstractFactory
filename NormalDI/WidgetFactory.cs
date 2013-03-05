using System;

namespace NormalDI
{
    public class WidgetFactory : WidgetFactoryBase
    {
        private readonly WidgetRepository _widgetRepository;
        public WidgetFactory(WidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }
        public override Widget CreateWidget(string name, Guid id)
        {
            return new Widget(name, id, _widgetRepository);
        }
    }
}
