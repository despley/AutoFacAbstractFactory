using System;

namespace NormalDI
{
    public class Element : ElementBase
    {
        public override string Description { get; set; }
        public override Guid Id { get; set; }
        public Element(string description, Guid id, ElementRepository elementRepository) : base(description, id, elementRepository)
        {
        }
    }
}
