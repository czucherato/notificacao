using System.Threading.Tasks;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Notificacao.Interfaces.Validacao
{
    public interface INotificarValidacao
    {
        IList<INotificacao> Validacao { get; }

        bool HaNotificacoes();

        void Adicionar(string mensagem);

        Task AdicionarAsync(string mensagem);

        void Adicionar(ValidationResult result);

        void Adicionar(INotificarValidacao notificacao);

        void Limpar();
    }
}
