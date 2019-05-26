using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManipulandoStrings.UnitTest
{
    [TestClass]
    public class StreamUnitTest
    {
        [TestMethod]
        public void Validar_Primeiro_Caractere_Stream_Igual_T()
        {
            var stream = new Stream() { Sentence = "teste" };

            Assert.IsTrue(stream.GetNext() == 't');
        }

        [TestMethod]
        public void Validar_Existe_Stream()
        {
            var stream = new Stream() { Sentence = "teste" };

            Assert.IsTrue(stream.HasNext());
        }

        [TestMethod]
        public void Validar_Fim_Stream()
        {
            var stream = new Stream() { Sentence = "" };

            Assert.IsTrue(!stream.HasNext());
        }

        [TestMethod]
        public void Validar_Posicao_Inicial_Stream()
        {
            var stream = new Stream() { Sentence = "teste" };

            Assert.IsTrue(stream.Index() == -1);
        }
    }
}
