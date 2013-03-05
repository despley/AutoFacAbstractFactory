using DemoOfCreatingObjectsAtLowerLevels;

namespace PoorMansDI
{
    public class AFactory
    {
        private readonly BFactory _bFactory;
        public AFactory(BFactory bFactory)
        {
            _bFactory = bFactory;
        }
        public A GetA()
        {
            return new A(_bFactory);
        }
    }
}
