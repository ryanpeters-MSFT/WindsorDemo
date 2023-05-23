using Castle.Windsor;
using Castle.Windsor.Installer;

public class WindsorContainerBuilder
{
    public IServiceCollection Services { get; }

    public WindsorContainerBuilder(IServiceCollection services)
    {
        Services = services;
    }

    public WindsorContainer BuildContainer()
    {
        var container = new WindsorContainer();

        container.Install(FromAssembly.InThisApplication(System.Reflection.Assembly.GetExecutingAssembly()));

        return container;
    }
}
