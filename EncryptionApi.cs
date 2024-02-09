var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => StartUpPage());
app.MapGet("/encrypt", (string text) => EncryptDecrypt(text));

app.Run();

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

static string StartUpPage()
{
    return "Write /encrypt in the url followed by\n ?text= and some text and it will encrypt it.\n By typing in the encrypted text in the url\n it will decrypt it back to what it was\n\n Example: /encrypt?text=Smith";
}
