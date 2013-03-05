using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoOfCreatingObjectsAtLowerLevels;

namespace PoorMansDI
{
    public class A
    {
        private BFactory _bFactory; 
        public A(BFactory bFactory)
        {
            _bFactory = bFactory;
        }
        public B GetB()
        {
            return _bFactory.CreateB();
        }
    }


}
