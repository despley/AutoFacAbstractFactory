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
        public abstract ElementBase CreateElement(string description, Guid id);
        public abstract ElementBase CreateRadioElement(string description, Guid id);
        public abstract ElementBase CreateTextElement(string description, Guid id);
        public abstract ElementBase CreateStrangeDatabaseDrivenElement(string description, Guid id);
    }
}