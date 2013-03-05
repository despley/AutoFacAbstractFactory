using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoorMansDI
{
    public class B
    {
        private WidgetFactory _widgetFactory; 
        public B(WidgetFactory widgetFactory)
        {
            _widgetFactory = widgetFactory;
        }

        public Widget CreateWidget(string name, Guid id)
        {
            return _widgetFactory.CreateWidget(name, id);
        }
    }
}
