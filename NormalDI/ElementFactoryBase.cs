using System;

namespace NormalDI
{
    public abstract class ElementFactoryBase
    {
        public abstract ElementBase CreateElement(string name, Guid id);
        public abstract ElementBase CreateRadioElement(string name, Guid id);
        public abstract ElementBase CreateTextElement(string name, Guid id);
        public abstract ElementBase CreateStrangeDatabaseDrivenElement(string name, Guid id);
    }
}