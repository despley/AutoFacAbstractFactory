using System;

namespace NormalDI
{
    public class RadioButtonElement :Element
    {
        private readonly string _description;
        public RadioButtonElement(string description, Guid id, ElementRepositoryBase elementRepository)
            : base(description, id, elementRepository)
        {
            _description = description;
        }

        public string HeyRadioStuffNotElementStuff()
        {
            return "I have buttons because I am a radio button set";
        }


        public override string Description
        {
            get { return _description + HeyRadioStuffNotElementStuff(); }

        }
    }
}
