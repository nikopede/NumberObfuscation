using NumberObfuscation.Operations;
using NumberObfuscation.Options;

namespace NumberObfuscation;

public class NumberObfuscationService : INumberObfuscationService
{
    private readonly NumberObfuscationOptions _obfuscationOptions;

    public NumberObfuscationService( NumberObfuscationOptions obfuscationOptions)
    {
        _obfuscationOptions = obfuscationOptions;
    }

    public string ObfuscateAsString(int number)
    {
        var reversedNumber = BitOperations.ReverseBits((uint) number);
        var obfuscatedNumber = BitOperations.Xor((uint) _obfuscationOptions.ObfuscationKey!, reversedNumber);
        return obfuscatedNumber.ToString();
    }

    public int ObfuscateAsInt(int number)
    {
        var reversedNumber = BitOperations.ReverseBits((uint) number);
        var obfuscatedNumber = BitOperations.Xor((uint) _obfuscationOptions.ObfuscationKey!, reversedNumber);
        return (int) obfuscatedNumber;
    }

    public int DeobfuscateInt(int number)
    {
        var deobfuscatedNumber = BitOperations.Xor((uint) _obfuscationOptions.ObfuscationKey!, (uint) number);
        return (int) BitOperations.ReverseBits(deobfuscatedNumber);
    }

    public int DeobfuscateString(string number)
    {
        var deobfuscatedNumber = BitOperations.Xor((uint) _obfuscationOptions.ObfuscationKey!, uint.Parse(number));
        return (int) BitOperations.ReverseBits(deobfuscatedNumber);
    }
}