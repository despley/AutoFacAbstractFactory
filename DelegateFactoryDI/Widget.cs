using System;

namespace DelegateFactoryDI
{
    public class Widget
    {
        public delegate Widget Factory(string name, Guid id);
        private WidgetRepository _widgetRepository;
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Widget(string name, Guid id, WidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
            Id = id;
            Name = name;
        }
    }
}
