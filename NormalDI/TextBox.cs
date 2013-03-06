using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NormalDI
{
    public class TextBox : ElementBase
    {
        public TextBox(string description, Guid id, ElementRepository elementRepository) : base(description, id, elementRepository)
        {
        }

        public override string Description
        { get; set; }

        public override Guid Id
        { get; set; }
    }
}
