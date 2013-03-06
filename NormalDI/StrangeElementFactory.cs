using System;

namespace NormalDI
{
    public class StrangeElementFactory : ElementFactory
    {
        private readonly StrangeElementRespoitory _strangeElementRespoitory;
        public StrangeElementFactory(StrangeElementRespoitory strangeElementRespoitory, ElementRepositoryBase elementRepository) : base(elementRepository)
        {
            _strangeElementRespoitory = strangeElementRespoitory;
        }

        public override ElementBase CreateStrangeDatabaseDrivenElement(string name, Guid id)
        {
            return new StrangeDatabaseDrivenElement(name, id, _strangeElementRespoitory);
        }
    }
}
