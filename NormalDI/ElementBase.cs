using System;

namespace NormalDI
{
    public abstract class ElementBase
    {
        private ElementRepository _elementRepository;

        public ElementBase(string description, Guid id, ElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
            Id = id;
            Description = description;
        }

        public abstract string Description { get; set; }
        public abstract Guid Id { get; set; }
    }
}