using Notificacao.Interfaces.Validacao;

namespace Notificacao.Validacao
{
    public class Notificacao : INotificacao
    {
        public Notificacao(string mensagem)
        {
            this.Mensagem = mensagem;
        }

        public string Mensagem { get; private set; }
    }
}
