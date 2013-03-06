using System;

namespace NormalDI
{
    public abstract class ScreenBase
    {
        public string ScreenName;
        protected ScreenBase(string screenName)
        {
            ScreenName = screenName;
        }
        [Obsolete]
        public abstract ElementBase CreateElement(string name, Guid id);
        public abstract ElementBase CreateRadioElement(string name, Guid id);
        public abstract ElementBase CreateTextElement(string name, Guid id);
    }
}