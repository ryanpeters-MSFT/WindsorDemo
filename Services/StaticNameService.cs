namespace Windsor.Services;

public class StaticNameService : INameService
{
    public string GetName()
    {
        return "Ryan";
    }
}