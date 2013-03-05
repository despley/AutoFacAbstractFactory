using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoorMansDI
{
    public class WidgetFactory
    {
        private WidgetRepository _widgetRepository;
        public WidgetFactory(WidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }
        internal Widget CreateWidget(string name, Guid id)
        {
            return new Widget(name, id, _widgetRepository);
        }
    }
}
