
namespace DelegateFactoryDI
{
    public abstract class ABase
    {
        public string WhatYouWantFromA;
        protected ABase(string whatYouWantFromA)
        {
            WhatYouWantFromA = whatYouWantFromA;
        }
        public abstract BBase GetB(string whatYouWantFromB);
    }
}