namespace Flowsy.DependencyInjection;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ServiceTagAttribute : Attribute
{
    public ServiceTagAttribute(string value)
    {
        Value = value;
    }

    public string Value { get; }
}
