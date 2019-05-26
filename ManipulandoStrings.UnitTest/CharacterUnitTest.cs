using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManipulandoStrings.UnitTest
{
    [TestClass]
    public class CharacterUnitTest
    {
        [TestMethod]
        public void Validar_Stream_Sem_Vogal()
        {
            var stream = new Stream() { Sentence = "try" };

            var vogal = Character.FirstChar(stream);

            Assert.AreEqual(vogal, '\0');
        }

        [TestMethod]
        public void Validar_Stream_Com_Vogal_Repetida()
        {
            var stream = new Stream() { Sentence = "teste" };

            var vogal = Character.FirstChar(stream);

            Assert.AreEqual(vogal, '\0');
        }

        [TestMethod]
        public void Validar_Stream_Duas_Vogais()
        {
            var stream = new Stream() { Sentence = "tatu" };

            var vogal = Character.FirstChar(stream);

            Assert.AreEqual(vogal, 'u');
        }

        [TestMethod]
        public void Validar_Stream_Vogal_Repetida_Outra_Nao()
        {
            var stream = new Stream() { Sentence = "araraiarara" };

            var vogal = Character.FirstChar(stream);

            Assert.AreEqual(vogal, 'i');
        }

        [TestMethod]
        public void Validar_Stream_Muitas_Vogais_Repetidas()
        {
            var stream = new Stream() { Sentence = "aaaahdsuhduseeiiiiiooooouuaanmmcjjch" };

            var vogal = Character.FirstChar(stream);

            Assert.AreEqual(vogal, '\0');
        }

        [TestMethod]
        public void Validar_Stream_Muitas_Vogais_Repetidas_Uma_Nao()
        {
            var stream = new Stream() { Sentence = "aaaahdsuhduseiiiiiooooouuaanmmcjjch" };

            var vogal = Character.FirstChar(stream);

            Assert.AreEqual(vogal, 'e');
        }
    }
}
