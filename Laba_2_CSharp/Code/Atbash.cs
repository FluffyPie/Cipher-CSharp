
namespace Laba_2_CSharp.Code
{
    public class Atbash : ICipher
    {
        
        string RussianLetters = "абвгдеёжзийклмнопрстуфхцчшщьъэюя";
        string EnglishLetters = "abcdefghijklmnopqrstuvwxyz";
        string Letters;

        private string Reverse(string Text)
        {

            string ReversedText = "";
            foreach (var Symbol in Text)
            {
                ReversedText = Symbol + ReversedText;
            }

            return ReversedText;
        }

        private string EncodeOrDecode(string Text, string Symbols, string Cipher)
        {
           
            Text = Text.ToLower();

            string ResultedText = "";
            
            for (int i = 0; i < Text.Length; i++)
            {
                if (!char.IsLetter(Text[i]))
                {
                    ResultedText += Text[i];
                    continue;
                }
                int Index = Letters.IndexOf(Text[i]);
                if (Index >= 0)
                {
     
                    ResultedText += Cipher[Index].ToString();
                }
            }

            return ResultedText;
        }
        public string Encode(string Text, string Keyword = "Default")
        {
            if (Properties.Settings.Default.Language == "Russian")
                Letters = RussianLetters;
            else
                Letters = EnglishLetters;
            return EncodeOrDecode(Text, Letters, Reverse(Letters));
        }
        public string Decode(string Text, string Keyword = "Default")   
        {
            if (Properties.Settings.Default.Language == "Russian")
                Letters = RussianLetters;
            else
                Letters = EnglishLetters;
            return EncodeOrDecode(Text, Reverse(Letters), Letters);
        }
    }
}
