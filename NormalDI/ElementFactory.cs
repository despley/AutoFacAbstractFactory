using System;

namespace NormalDI
{
    public class ElementFactory : ElementFactoryBase
    {
        private readonly ElementRepositoryBase _elementRepository;
        public ElementFactory(ElementRepositoryBase elementRepository)
        {
            _elementRepository = elementRepository;
        }
        public override ElementBase CreateElement(string name, Guid id)
        {
            return new Element(name, id, _elementRepository);
        }

        public override ElementBase CreateRadioElement(string name, Guid id)
        {
            return new RadioButtonElement(name, id, _elementRepository);
        }

        public override ElementBase CreateTextElement(string name, Guid id)
        {
            return new TextBoxElement(name, id, _elementRepository);
        }

        public override ElementBase CreateStrangeDatabaseDrivenElement(string name, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
