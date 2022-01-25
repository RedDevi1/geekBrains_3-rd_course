using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s = "никита";
            var s1 = "программа работает на ура";
            var s2 = "33 котенка, 45 собак - это зоопарк";
            var s3 = "гуд баааай јмеееериикааа, оооо";
            var result = Program.TurnRoundString(s);
            var result1 = Program.TurnRoundString(s1);
            var result2 = Program.TurnRoundString(s2);
            var result3 = Program.TurnRoundString(s3);
            Assert.AreEqual("атикин", result);
            Assert.AreEqual("ару ан театобар аммаргорп", result1);
            Assert.AreEqual("крапооз отэ - кабос 54 ,акнеток 33", result2);
            Assert.AreEqual("оооо ,ааакииреееемј йааааб дуг", result3);
        }
    }
}
