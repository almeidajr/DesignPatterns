namespace DesignPatterns.Structural.Adapter;

public sealed class Adapter : ITarget
{
    private readonly ThirdPartyCode _thirdPartyCode;

    public Adapter(ThirdPartyCode thirdPartyCode)
    {
        _thirdPartyCode = thirdPartyCode;
    }

    public string GetRequest()
    {
        return _thirdPartyCode.GetSpecificRequest();
    }
}