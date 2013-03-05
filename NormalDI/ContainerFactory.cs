using Autofac;

namespace NormalDI
{
    public static class ContainerFactory
    {
        public static Runtime GetRuntime()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Runtime>();
            builder.RegisterType<AFactory>().As<AFactoryBase>();
            builder.RegisterType<BFactory>().As<BFactoryBase>();
            builder.RegisterType<WidgetFactory>().As<WidgetFactoryBase>();
            builder.RegisterType<WidgetRepository>();
            var container = builder.Build();
            return container.Resolve<Runtime>();
        }
    }
}
