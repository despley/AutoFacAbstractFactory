namespace DelegateFactoryDI
{
    public class A : ABase
    {
        public delegate A Factory(string whatYouWantFromA); 
        private readonly B.Factory _bFactory;
        public A(B.Factory bFactory, string whatYouWantFromA):base(whatYouWantFromA)
        {
            _bFactory = bFactory;
        }
        public override BBase GetB(string whatYouWantFromB)
        {
            return _bFactory(whatYouWantFromB);
        }
    }


}
