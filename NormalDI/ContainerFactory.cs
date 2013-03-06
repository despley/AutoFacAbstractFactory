using Autofac;

namespace NormalDI
{
    public static class ContainerFactory
    {
        public static Runtime GetRuntime()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Runtime>();
            builder.RegisterType<ModuleFactory>().As<ModuleFactoryBase>();
            builder.RegisterType<ScreenFactory>().As<ScreenFactoryBase>();
            builder.RegisterType<ElementFactory>().As<ElementFactoryBase>();
            builder.RegisterType<ElementRepository>().As<ElementRepositoryBase>();
            builder.RegisterType<StrangeElementRespoitory>();
            var container = builder.Build();
            return container.Resolve<Runtime>();
        }
    }
}
