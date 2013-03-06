namespace DelegateFactoryDI
{
    public class Module : ModuleBase
    {
        public delegate Module Factory(string whatYouWantFromA); 
        private readonly Screen.Factory _bFactory;
        public Module(Screen.Factory bFactory, string whatYouWantFromA):base(whatYouWantFromA)
        {
            _bFactory = bFactory;
        }
        public override ScreenBase GetB(string whatYouWantFromB)
        {
            return _bFactory(whatYouWantFromB);
        }
    }


}
