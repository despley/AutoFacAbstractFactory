
namespace DelegateFactoryDI
{
    public abstract class ModuleBase
    {
        public string WhatYouWantFromA;
        protected ModuleBase(string whatYouWantFromA)
        {
            WhatYouWantFromA = whatYouWantFromA;
        }
        public abstract ScreenBase GetB(string whatYouWantFromB);
    }
}