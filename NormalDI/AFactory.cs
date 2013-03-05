namespace NormalDI
{
    public class AFactory : AFactoryBase
    {
        private readonly BFactoryBase _bFactory;
        public AFactory(BFactoryBase bFactory)
        {
            _bFactory = bFactory;
        }
        public override ABase GetA(string whatYouWantFromA)
        {
            return new A(_bFactory, whatYouWantFromA);
        }
    }
}
