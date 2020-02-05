using System;
using System.Linq.Expressions;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Notificacao.Interfaces.Validacao
{
    public interface INotificarValidacao
    {
        IList<INotificacao> Validacao { get; }

        bool HaNotificacoes();

        void Adicionar(string mensagem);

        void Adicionar<TSource, TProperty>(string mensagem, TSource source, Expression<Func<TSource, TProperty>> expression);

        void Adicionar(ValidationResult result);

        void Adicionar(INotificarValidacao notificacao);

        void Limpar();
    }
}