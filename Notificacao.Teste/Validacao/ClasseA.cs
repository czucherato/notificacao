using Notificacao.Validacao;
using Notificacao.Interfaces.Validacao;

namespace Notificacao.Teste.Validacao
{
    internal class ClasseA : IAutoValidacao
    {
        public ClasseA()
        {
            _validacao = new ClasseAValidacao();
            Notificacoes = new NotificarValidacao();
        }

        public string Valor1 { get; set; }

        #region Validação

        private readonly ClasseAValidacao _validacao;

        public INotificarValidacao Notificacoes { get; private set; }

        public bool EhValido()
        {
            Notificacoes.Adicionar(_validacao.Validate(this));
            return Notificacoes.Validacao.Count > 0 ? false : true;
        }

        #endregion
    }
}
