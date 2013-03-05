using System;

namespace NormalDI
{
    public abstract class WidgetFactoryBase
    {
        public abstract Widget CreateWidget(string name, Guid id);
    }
}