using System;
using System.Collections.Generic;

namespace DelegateFactoryDI
{
    public class Runtime
    {
        private readonly Module.Factory _aFactory;
        public Runtime(Module.Factory aFactory)
        {
            _aFactory = aFactory;
        }
        public IList<Element> GetWidgets()
        {
            //Ask AFactory for a copy of Module
            var a1 = _aFactory("First Unqiue copy of Module");
            var b1 = a1.GetB("First Unqiue copy of Screen");
            var a2 = _aFactory("Second Unique copy of Module");
            var b2 = a2.GetB("Second Unqiue copy of Screen");
            IList<Element> widgets = new List<Element>();
            widgets.Add(b1.CreateWidget("iPhone", new Guid()));
            widgets.Add(b2.CreateWidget("Android", new Guid()));
            Debug(a1,b1,a2,b2);
            return widgets;
        }

        private void Debug(ModuleBase moduleBase1, ScreenBase screenBase1, ModuleBase moduleBase2, ScreenBase screenBase2)
        {
            Console.WriteLine(moduleBase1.WhatYouWantFromA);
            Console.WriteLine(screenBase1.WhatYouWantFromB);
            Console.WriteLine(moduleBase2.WhatYouWantFromA);
            Console.WriteLine(screenBase2.WhatYouWantFromB);
        }
    }
}
