using Xunit;
namespace UnitTest;

public class Encryption_Tester
{
    [Fact]
    public void EncryptDecryptTest()
    {
        string original = "This text will be encrypted and decrypted";

        string encrypted = EncryptDecrypt(original);

        string decrypted = EncryptDecrypt(encrypted);

        Assert.Equal(original, decrypted);
    }
    static string EncryptDecrypt(string text)
    {
        int encryptkey = 4;

        char[] chars = text.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = (char)(chars[i] ^ encryptkey);
        }
        return new string(chars);
    }
}