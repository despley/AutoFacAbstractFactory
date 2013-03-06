using System;

namespace NormalDI
{
    public class TextBoxElement : Element
    {
        public TextBoxElement(string description, Guid id, ElementRepositoryBase elementRepository)
            : base(description, id, elementRepository)
        {
        }

    }
}
