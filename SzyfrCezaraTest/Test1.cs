using SzyfrCezara;

namespace SzyfrCezaraTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void DanePodstawowe()
        {
            var wynik = Program.SzyfrujCezara(3, "abc");
            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void Zawijanie()
        {
            var wynik = Program.SzyfrujCezara(3, "xyz");
            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void Odszyfrowanie()
        {
            var wynik = Program.SzyfrujCezara(-3, "def");
            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void KluczWiekszyNizAlfaber()
        {
            var wynik = Program.SzyfrujCezara(29, "abc");
            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void SpacjaWTekscie()
        {
            var wynik = Program.SzyfrujCezara(2, "ab cd");
            Assert.AreEqual("cd ef", wynik);

        }
    }
}
