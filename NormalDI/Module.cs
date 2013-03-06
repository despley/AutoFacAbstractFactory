namespace NormalDI
{
    public class Module : ModuleBase
    {
        private readonly ScreenFactoryBase _screenFactory;
        public Module(ScreenFactoryBase screenFactory, string moduleName):base(moduleName)
        {
            _screenFactory = screenFactory;
        }
        public override ScreenBase CreateScreen(string screenName)
        {
            return _screenFactory.CreateScreen(screenName);
        }
    }


}
