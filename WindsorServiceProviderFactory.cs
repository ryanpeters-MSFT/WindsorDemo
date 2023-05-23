using Castle.Windsor.MsDependencyInjection;

public class WindsorServiceProviderFactory : IServiceProviderFactory<WindsorContainerBuilder>
{
    public WindsorContainerBuilder CreateBuilder(IServiceCollection services) => new WindsorContainerBuilder(services);

    public IServiceProvider CreateServiceProvider(WindsorContainerBuilder containerBuilder)
    {
        var container = containerBuilder.BuildContainer();

        var serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(container, containerBuilder.Services);

        return serviceProvider;
    }
}
