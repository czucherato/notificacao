using Notificacao.Validacao;
using Notificacao.Teste.Validacao;
using Notificacao.Interfaces.Validacao;
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

        [TestMethod]
        public void AdicionarNotificacoes()
        {
            var valor = new ClasseA();
            valor.EhValido();
            INotificarValidacao notificacoes = new NotificarValidacao();
            notificacoes.Adicionar(valor.Notificacoes);
        }

        [TestMethod]
        public void AdicionarMensagem()
        {
            var valor = new ClasseA();
            INotificarValidacao notificacoes = new NotificarValidacao();
            notificacoes.Adicionar("Teste", valor, x => x.Valor1);
        }
    }
}