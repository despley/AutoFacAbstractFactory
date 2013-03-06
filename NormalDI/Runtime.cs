using System;
using System.Collections.Generic;

namespace NormalDI
{
    public class Runtime
    {
        private readonly ModuleFactoryBase _moduleFactory;
        public Runtime(ModuleFactoryBase moduleFactory)
        {
            _moduleFactory = moduleFactory;
        }
        public IList<ElementBase> GetScreenElements()
        {
            //Ask ModuleFactory for a copy of Module
            var moduleBase1 = _moduleFactory.CreateModule("Conveyancing");
            var screenBase1 = moduleBase1.CreateScreen("Customers Address");
            var moduleBase2 = _moduleFactory.CreateModule("Simple Debt");
            var screenBase2 = moduleBase2.CreateScreen("Amount owed and customer details");
            IList<ElementBase> elements = new List<ElementBase>();
            elements.Add(screenBase1.CreateRadioElement("Radio button to choose if commerical property or not", Guid.NewGuid()));
            elements.Add(screenBase2.CreateTextElement("Describe why the monies are owed", Guid.NewGuid()));
            Debug(moduleBase1,screenBase1,moduleBase2,screenBase2);
            var r = (RadioButtonElement)screenBase1.CreateRadioElement("Special radio that is radio", Guid.NewGuid());
            var ele = (ElementBase) r;
            Console.WriteLine(ele.Id);
            Console.WriteLine(r.HeyRadioStuffNotElementStuff());
//            var strangeElement = screenBase1.CreateStrangeDatabaseDrivenElement("DATABASE DRIVEN: Created needing separate service than other elements", Guid.NewGuid());
//            Console.WriteLine(strangeElement.Description);
            return elements;
        }

        private void Debug(ModuleBase moduleBase1, ScreenBase screenBase1, ModuleBase moduleBase2, ScreenBase screenBase2)
        {
            Console.WriteLine(moduleBase1.ModuleName);
            Console.WriteLine(screenBase1.ScreenName);
            Console.WriteLine(moduleBase2.ModuleName);
            Console.WriteLine(screenBase2.ScreenName);
        }
    }
}
