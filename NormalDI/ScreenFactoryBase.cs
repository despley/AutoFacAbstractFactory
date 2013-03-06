namespace NormalDI
{
    public abstract class ScreenFactoryBase
    {
        public abstract ScreenBase CreateScreen(string screenName);
    }
}