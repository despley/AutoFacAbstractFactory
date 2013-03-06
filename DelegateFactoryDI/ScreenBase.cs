using System;

namespace DelegateFactoryDI
{
    public abstract class ScreenBase
    {
        public string WhatYouWantFromB;
        protected ScreenBase(string whatYouWantFromB)
        {
            WhatYouWantFromB = whatYouWantFromB;
        }
        public abstract Element CreateWidget(string name, Guid id);
    }
}