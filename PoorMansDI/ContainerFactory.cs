using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using DemoOfCreatingObjectsAtLowerLevels;

namespace PoorMansDI
{
    public static class ContainerFactory
    {
        public static DelegateRuntime GetRuntime()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<DelegateRuntime>();
            builder.RegisterType<AFactory>();
            builder.RegisterType<BFactory>();
            builder.RegisterType<WidgetFactory>();
            builder.RegisterType<WidgetRepository>();
            var container = builder.Build();
            return container.Resolve<DelegateRuntime>();
        }
    }
}
