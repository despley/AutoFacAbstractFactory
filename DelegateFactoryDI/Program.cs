using System;
using System.Collections.Generic;

namespace DelegateFactoryDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //I need two widgets and I want to display their names and get their ID's from the database - weird, I know, normally I would create them from the database
            //There are gonig to be extra layers in this app to show how it works in practise!
            //All of the extra layers are going to be named as letters in Alphabetical order 
            //It is assumed that a new copy of both class Module and class Screen are needed in this example, hence the use of new Module()

            IList<Element> widgets = ContainerFactory.GetRuntime().GetWidgets();
            foreach (Element w in widgets)
            {
                Console.WriteLine(w.Name);
            }
            Console.ReadKey();
        }
    }
}
