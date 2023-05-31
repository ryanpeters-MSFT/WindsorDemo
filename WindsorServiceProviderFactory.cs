using Castle.Windsor.MsDependencyInjection;

public class WindsorServiceProviderFactory : IServiceProviderFactory<WindsorContainerBuilder>
{
    private IServiceCollection services;

    public WindsorContainerBuilder CreateBuilder(IServiceCollection services)
    {
        this.services = services;

        return new WindsorContainerBuilder();
    }

    public IServiceProvider CreateServiceProvider(WindsorContainerBuilder containerBuilder)
    {
        var container = containerBuilder.BuildContainer();

        var serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(container, services);

        return serviceProvider;
    }
}
