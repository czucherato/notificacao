using Notificacao.Teste.Validacao;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Notificacao.Teste.Teste
{
    [TestClass]
    public class ClasseATeste
    {
        [TestMethod]
        public void EhValido()
        {
            var valor = new ClasseA();

            Assert.IsFalse(valor.EhValido());
        }
    }
}