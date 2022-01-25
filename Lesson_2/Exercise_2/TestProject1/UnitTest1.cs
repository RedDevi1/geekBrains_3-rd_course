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
            var s = "������";
            var s1 = "��������� �������� �� ���";
            var s2 = "33 �������, 45 ����� - ��� �������";
            var s3 = "��� ������ �������������, ����";
            var result = Program.TurnRoundString(s);
            var result1 = Program.TurnRoundString(s1);
            var result2 = Program.TurnRoundString(s2);
            var result3 = Program.TurnRoundString(s3);
            Assert.AreEqual("������", result);
            Assert.AreEqual("��� �� �������� ���������", result1);
            Assert.AreEqual("������� ��� - ����� 54 ,������� 33", result2);
            Assert.AreEqual("���� ,������������� ������ ���", result3);
        }
    }
}
