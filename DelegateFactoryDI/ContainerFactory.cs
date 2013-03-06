using Autofac;

namespace DelegateFactoryDI
{
    public static class ContainerFactory
    {
        public static Runtime GetRuntime()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Runtime>();
            builder.RegisterType<Module>();
            builder.RegisterType<Screen>();
            builder.RegisterType<Element>();
            builder.RegisterType<ElementRepository>();
            var container = builder.Build();
            return container.Resolve<Runtime>();
        }
    }
}
