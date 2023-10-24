using Microsoft.Extensions.DependencyInjection;
using NumberObfuscation;
using NumberObfuscation.DependencyInjection;
using Xunit;

namespace NumberObfuscationTests;

public class NumberObfuscationTests
{
    private const int ObfuscationKey = 95214582;

    private readonly INumberObfuscationService _service;

    public NumberObfuscationTests()
    {
        var services = new ServiceCollection();
        services.AddNumberObfuscation(options => options.ObfuscationKey = ObfuscationKey);
        var provider = services.BuildServiceProvider();
        _service = provider.GetRequiredService<INumberObfuscationService>();
    }

    [Fact]
    public void Test_ObfuscateAndDeobfuscateInt()
    {
        const int original = 512;
        var obfuscated = _service.ObfuscateAsInt(original);
        var deobfuscated = _service.DeobfuscateInt(obfuscated);
        Assert.Equal(original, deobfuscated);
    }

    [Fact]
    public void Test_ObfuscateAndDeobfuscateString()
    {
        const int original = 1239675;
        var obfuscated = _service.ObfuscateAsString(original);
        var deobfuscated = _service.DeobfuscateString(obfuscated);
        Assert.Equal(original, deobfuscated);
    }
}