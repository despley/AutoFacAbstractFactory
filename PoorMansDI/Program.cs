using System;
using System.Collections.Generic;

namespace PoorMansDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //I need two widgets and I want to display their names and get their ID's from the database - weird, I know, normally I would create them from the database
            //There are gonig to be extra layers in this app to show how it works in practise!
            //All of the extra layers are going to be named as letters in Alphabetical order 
            //It is assumed that a new copy of both class A and class B are needed in this example, hence the use of new A()

            IList<Widget> widgets = ContainerFactory.GetRuntime().GetWidgets();
            foreach (Widget w in widgets)
            {
                Console.WriteLine(w.Name);
            }
            Console.ReadKey();
        }
    }
}
