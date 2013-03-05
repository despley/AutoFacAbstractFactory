using System;
using System.Collections.Generic;

namespace NormalDI
{
    public class Runtime
    {
        private readonly AFactoryBase _aFactory;
        public Runtime(AFactoryBase aFactory)
        {
            _aFactory = aFactory;
        }
        public IList<Widget> GetWidgets()
        {
            //Ask AFactory for a copy of A
            var a1 = _aFactory.GetA("First Unqiue copy of A");
            var b1 = a1.GetB("First Unqiue copy of B");
            var a2 = _aFactory.GetA("Second Unique copy of A");
            var b2 = a2.GetB("Second Unqiue copy of B");
            IList<Widget> widgets = new List<Widget>();
            widgets.Add(b1.CreateWidget("iPhone", new Guid()));
            widgets.Add(b2.CreateWidget("Android", new Guid()));
            Debug(a1,b1,a2,b2);
            return widgets;
        }

        private void Debug(ABase aBase1, BBase bBase1, ABase aBase2, BBase bBase2)
        {
            Console.WriteLine(aBase1.WhatYouWantFromA);
            Console.WriteLine(bBase1.WhatYouWantFromB);
            Console.WriteLine(aBase2.WhatYouWantFromA);
            Console.WriteLine(bBase2.WhatYouWantFromB);
        }
    }
}
