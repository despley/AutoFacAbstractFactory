namespace NormalDI
{
    public class A : ABase
    {
        private readonly BFactoryBase _bFactory;
        public A(BFactoryBase bFactory, string whatYouWantFromA):base(whatYouWantFromA)
        {
            _bFactory = bFactory;
        }
        public override BBase GetB(string whatYouWantFromB)
        {
            return _bFactory.CreateB(whatYouWantFromB);
        }
    }


}
