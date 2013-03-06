namespace NormalDI
{
    public abstract class ModuleFactoryBase
    {
        public abstract ModuleBase CreateModule(string nameOfModule);
    }
}