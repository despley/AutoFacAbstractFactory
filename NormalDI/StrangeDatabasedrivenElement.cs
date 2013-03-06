using System;

namespace NormalDI
{
    public class StrangeDatabaseDrivenElement : Element
    {
        private StrangeElementRespoitory _strangeElementRespoitory;

        public StrangeDatabaseDrivenElement(string description, Guid id, StrangeElementRespoitory elementRepository) : base(description, id, elementRepository)
        {
            _strangeElementRespoitory = elementRepository;
        }
    }
}
