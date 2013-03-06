using System;

namespace NormalDI
{
    public class Element : ElementBase
    {
        private readonly ElementRepositoryBase _elementRepository;
        private readonly Guid _id;
        private readonly string _description;
        public override string Description {
            get { return _description; }
        }
        public override Guid Id { get { return _id; } }
        public Element(string description, Guid id, ElementRepositoryBase elementRepository)
        {
            _elementRepository = elementRepository;
            _description = description;
            _id = id;
        }
    }
}
