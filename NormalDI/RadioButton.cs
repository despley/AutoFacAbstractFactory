using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NormalDI
{
    public class RadioButton :ElementBase
    {
        private string _description;
        public RadioButton(string description, Guid id, ElementRepository elementRepository) : base(description, id, elementRepository)
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
            
            set { _description = value; } }

        public override Guid Id
        {get; set; }
    }
}
