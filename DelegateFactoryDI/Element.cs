using System;

namespace DelegateFactoryDI
{
    public class Element
    {
        public delegate Element Factory(string name, Guid id);
        private ElementRepository _elementRepository;
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Element(string name, Guid id, ElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
            Id = id;
            Name = name;
        }
    }
}
