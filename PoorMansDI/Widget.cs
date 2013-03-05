using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoorMansDI
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
