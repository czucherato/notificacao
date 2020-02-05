using Notificacao.Interfaces.Validacao;

namespace Notificacao.Validacao
{
    public class Notificacao : INotificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public Notificacao(string mensagem, string referencia)
            : this(mensagem)
        {
            Referencia = referencia;
        }

        public string Mensagem { get; private set; }

        public string Referencia { get; private set; }
    }
}