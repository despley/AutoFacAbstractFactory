using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoorMansDI
{
    public class DelegateRuntime
    {
        private AFactory _aFactory;
        public DelegateRuntime(AFactory aFactory)
        {
            _aFactory = aFactory;
        }
        public IList<Widget> GetWidgets()
        {
            //Ask AFactory for a copy of A
            A a = _aFactory.GetA();
            B b = a.GetB();
            IList<Widget> widgets = new List<Widget>();
            widgets.Add(b.CreateWidget("iPhone", new Guid()));
            widgets.Add(b.CreateWidget("Android", new Guid()));
            return widgets;
        }
    }
}
