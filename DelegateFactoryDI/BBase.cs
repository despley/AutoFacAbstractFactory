using System;

namespace DelegateFactoryDI
{
    public abstract class BBase
    {
        public string WhatYouWantFromB;
        protected BBase(string whatYouWantFromB)
        {
            WhatYouWantFromB = whatYouWantFromB;
        }
        public abstract Widget CreateWidget(string name, Guid id);
    }
}