using Castle.Windsor;
using Castle.Windsor.Installer;

public class WindsorContainerBuilder
{
    public WindsorContainer BuildContainer()
    {
        var container = new WindsorContainer();

        container.Install(FromAssembly.InThisApplication(System.Reflection.Assembly.GetExecutingAssembly()));

        return container;
    }
}
