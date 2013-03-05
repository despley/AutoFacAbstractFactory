using Autofac;

namespace DelegateFactoryDI
{
    public static class ContainerFactory
    {
        public static Runtime GetRuntime()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Runtime>();
            builder.RegisterType<A>();
            builder.RegisterType<B>();
            builder.RegisterType<Widget>();
            builder.RegisterType<WidgetRepository>();
            var container = builder.Build();
            return container.Resolve<Runtime>();
        }
    }
}
