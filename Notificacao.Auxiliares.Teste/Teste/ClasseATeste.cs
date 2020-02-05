using Notificacao.Auxiliares.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Notificacao.Auxiliares.Teste.Teste
{
    [TestClass]
    public class ClasseATeste
    {
        [TestMethod]
        public void EhValido()
        {
            var valor = new ClasseA("Teste");
            Assert.AreEqual(PropertyInfoExtension.GetPropertyInfo(valor, x => x.Valor1).Name, "Valor1");
        }
    }
}