
namespace Laba_2_CSharp.Code
{
    public interface ICipher
    {
        string Encode(string text, string key);
        string Decode(string text, string key);
    }
}
