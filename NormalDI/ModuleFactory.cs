namespace NormalDI
{
    public class ModuleFactory : ModuleFactoryBase
    {
        private readonly ScreenFactoryBase _screenFactory;
        public ModuleFactory(ScreenFactoryBase screenFactory)
        {
            _screenFactory = screenFactory;
        }
        public override ModuleBase CreateModule(string nameOfModule)
        {
            return new Module(_screenFactory, nameOfModule);
        }
    }
}
