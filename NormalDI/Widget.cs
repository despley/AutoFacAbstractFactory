using System;

namespace NormalDI
{
    public class Widget
    {
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
