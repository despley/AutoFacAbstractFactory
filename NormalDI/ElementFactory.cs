using System;

namespace NormalDI
{
    public class ElementFactory : ElementFactoryBase
    {
        private readonly ElementRepositoryBase _elementRepository;
        private readonly StrangeElementRespoitory _strangeElementRespoitory;
        public ElementFactory(ElementRepositoryBase elementRepository)
        {
            _elementRepository = elementRepository;
        }
        public ElementFactory(ElementRepositoryBase elementRepository, StrangeElementRespoitory strangeElementRespoitory): this(elementRepository)
        {
            _strangeElementRespoitory = strangeElementRespoitory;
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
            return new StrangeDatabaseDrivenElement(name, id, _strangeElementRespoitory);
        }
    }
}
