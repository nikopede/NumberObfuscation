using NumberObfuscation.Operations;

namespace NumberObfuscationTests;

using Xunit;

public class BitOperationsTests
{
    [Fact]
    public void Test_ReverseBits_1()
    {
        const uint value = 1; // binary: 00000000000000000000000000000001
        const uint expected = 2147483648; // binary: 10000000000000000000000000000000
        Assert.Equal(expected, BitOperations.ReverseBits(value));
    }

    [Fact]
    public void Test_ReverseBits_2()
    {
        const uint value = 2; // binary: 00000000000000000000000000000010
        const uint expected = 1073741824; // binary: 01000000000000000000000000000000
        Assert.Equal(expected, BitOperations.ReverseBits(value));
    }

    [Fact]
    public void Test_ReverseBits_3()
    {
        const uint value = 1258718; // binary: 00000000000000000000000000000011
        const uint expected = 2066532352; // binary: 11000000000000000000000000000000
        Assert.Equal(expected, BitOperations.ReverseBits(value));
    }
    
    [Fact]
    public void Test_ReverseBits_4()
    {
        const uint value = 3221225472; // binary: 00000000000000000000000000000011
        const uint expected = 3; // binary: 11000000000000000000000000000000
        Assert.Equal(expected, BitOperations.ReverseBits(value));
    }
}