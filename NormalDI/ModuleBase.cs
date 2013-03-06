namespace NormalDI
{
    public abstract class ModuleBase
    {
        public string ModuleName;

        protected ModuleBase(string moduleName)
        {
            ModuleName = moduleName;
        }
        public abstract ScreenBase CreateScreen(string screenName);
    }
}