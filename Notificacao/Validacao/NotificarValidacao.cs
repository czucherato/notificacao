using System.Threading.Tasks;
using FluentValidation.Results;
using System.Collections.Generic;
using Notificacao.Interfaces.Validacao;

namespace Notificacao.Validacao
{
    public class NotificarValidacao : INotificarValidacao
    {
        public NotificarValidacao()
        {
            this.Validacao = new List<INotificacao>();
        }

        public IList<INotificacao> Validacao { get; private set; }

        public void Adicionar(string mensagem) => this.Validacao.Add(new Notificacao(mensagem));

        public Task AdicionarAsync(string mensagem) => new Task(() => this.Adicionar(mensagem));

        public void Adicionar(ValidationResult result)
        {
            ((List<ValidationFailure>)result.Errors).ForEach(x => this.Validacao.Add(new Notificacao(x.ErrorMessage)));
        }

        public void Adicionar(INotificarValidacao notificacao)
        {
            ((List<INotificacao>)notificacao.Validacao).ForEach(x => this.Validacao.Add(new Notificacao(x.Mensagem)));
        }

        public bool HaNotificacoes() => this.Validacao.Count > 0;

        public void Limpar() => this.Validacao.Clear();
    }
}
