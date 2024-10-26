namespace Legacy.Webservice
{
    using Autofac;
    using Legacy.Core;
    using Legacy.Integrations;

    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();

            return builder.Build();
        }
    }
}
