using System;

namespace NormalDI
{
    public abstract class ElementBase
    {
        public abstract string Description { get;  }
        public abstract Guid Id { get; }
    }
}