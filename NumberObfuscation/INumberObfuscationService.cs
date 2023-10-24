namespace NumberObfuscation;

public interface INumberObfuscationService
{
    public string ObfuscateAsString(int number);
    public int ObfuscateAsInt(int number);
    public int DeobfuscateInt(int number);
    public int DeobfuscateString(string number);

}