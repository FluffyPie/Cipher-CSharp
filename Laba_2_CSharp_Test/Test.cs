using Laba_2_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba_2_CSharp_Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void VigenereTestOne()
        {
            Laba_2_CSharp.Properties.Settings.Default.Language = "English";
            
            string TestedText = "My heart and actions are utterly unclouded. They are all those of 'Justice'. You're experienced it, didnt you?";
            string TestedKeyword = "DirtyDeedsDoneDirtyCheap";
            string ExpectedText = "pg yxyux eqv dqgmrvj tpg bxttutp nlfpsxvhr. glhg rkc csp twrav hd 'mywwafs'. lsx'zv xvrlvitqkvw gw, hmgfw mby?";
            
            Laba_2_CSharp.Code.Vigenere VG = new Laba_2_CSharp.Code.Vigenere();
            Assert.AreEqual(ExpectedText.ToUpper(), VG.Encode(TestedText, TestedKeyword));


        }
        [TestMethod]
        public void VigenereTestTwo()
        {
            Laba_2_CSharp.Properties.Settings.Default.Language = "Russian";
            
            string TestedText = "«ЯТРЙАМ ЪГЪ, УИЫУР? ФЦХЛСЫТЩЙ ЛЧЦПАГ ФПЬ Б ЧЦПЬЧЁ ШСНЙТР Щ ПЬО. Й ЫГНЙДЛ ФЧ ЦТУЁ ДЧБНЦЪ. ЮИКЖЗП ЗМ ИЖЯГ ЩЧСКЛ. ЪЙУЙВР ТДЖРЁЗЯ, ПЬБ ФХЮНЮЩЛКР ФСЕ РЁХЯЗЫ. АУ НАЧ… ЁЭЦ ЁРЖ РЕЬЦ»";
            string TestedKeyword = "ЧерезТернииКЗвездам";
            string ExpectedText = "«Знаешь что, Карло? Последние десять лет я только убивал и всё. Я убивал за свою страну. Убивал за свою семью. Убивал каждого, кто переходил мне дорогу. Но это… Это для меня»";

            Laba_2_CSharp.Code.Vigenere VG = new Laba_2_CSharp.Code.Vigenere();
            Assert.AreEqual(ExpectedText.ToLower(), VG.Decode(TestedText, TestedKeyword));


        }
   
      
        [TestMethod]
        public void AtbashTestOne()
        {
            Laba_2_CSharp.Properties.Settings.Default.Language = "English";

            string TestedText = "«What's the matter...? Are you simply going to watch? Are you forsaking him to save yourself? Death awaits him if you do nothing. Was your previous decision a mistake then?  Very well... I have heeded your resolve. Vow to me. I am thou, thou art I... Thou who art willing to perform all sacrilegious acts for thine own justice! Call upon my name, and release thy rage! Show the strength of thy will to ascertain all on thine own, though thou be chained to Hell itself!»";
            string ExpectedText = "«Dszg'h gsv nzggvi...? Ziv blf hrnkob tlrmt gl dzgxs? Ziv blf ulihzprmt srn gl hzev blfihvou? Wvzgs zdzrgh srn ru blf wl mlgsrmt. Dzh blfi kiverlfh wvxrhrlm z nrhgzpv gsvm?  Evib dvoo... R szev svvwvw blfi ivhloev. Eld gl nv. R zn gslf, gslf zig R... Gslf dsl zig droormt gl kviulin zoo hzxirovtrlfh zxgh uli gsrmv ldm qfhgrxv! Xzoo fklm nb mznv, zmw ivovzhv gsb iztv! Hsld gsv hgivmtgs lu gsb droo gl zhxvigzrm zoo lm gsrmv ldm, gslfts gslf yv xszrmvw gl Svoo rghvou!»";


            Laba_2_CSharp.Code.Atbash AB = new Laba_2_CSharp.Code.Atbash();
            Assert.AreEqual(ExpectedText.ToLower(), AB.Encode(TestedText, null));


        }
        [TestMethod]
        public void AtbashTestTwo()
        {
            Laba_2_CSharp.Properties.Settings.Default.Language = "Russian";

            string ExpectedText = "- Сойдись со мной в поединке! - Сначала со своими сапогами сойдись... Недомерок...";
            string TestedText = "- мпфьхмд мп српф э опщьхрущ! - мряжятя мп мэпхсх мяопъясх мпфьхмд... рщьпсщнпу...";


            Laba_2_CSharp.Code.Atbash AB = new Laba_2_CSharp.Code.Atbash();
            Assert.AreEqual(ExpectedText.ToLower(), AB.Encode(TestedText, null));


        }
    }

}
