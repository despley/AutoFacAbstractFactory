using System;

namespace NormalDI
{
    public class ElementFactory : ElementFactoryBase
    {
        private readonly ElementRepository _elementRepository;
        public ElementFactory(ElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
        }
        public override ElementBase CreateElement(string name, Guid id)
        {
            return new Element(name, id, _elementRepository);
        }

        public override ElementBase CreateRadioElement(string name, Guid id)
        {
            return new RadioButton(name, id, _elementRepository);
        }

        public override ElementBase CreateTextElement(string name, Guid id)
        {
            return new TextBox(name, id, _elementRepository);
        }
    }
}
