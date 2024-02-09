var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => StartUpPage());
app.MapGet("/encrypt", (string text, int key) => EncryptDecrypt(text, key));
app.MapGet("/decrypt", (string text, int key) => EncryptDecrypt(text, key));


app.Run();

static string EncryptDecrypt(string inputText, int cryptKey)
{
    char[] chars = inputText.ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
        chars[i] = (char)(chars[i] ^ cryptKey);
    }
    return new string(chars);
}

static string StartUpPage()
{
    return $"On this application you can encrypt text\nand decrypt it with custom encryption values.\n\nYou will be typing a string value\nand a crypto key value\n\nAn example for encrypting a name with a key value of 4 is:\n/encrypt?text=Smith&key=4\nAnd for decrypting:\n/decrypt?text=Wimpl&key=4\n\nAll that you need to change is what follows the = signs\nuntil there is a & symbol";
}
