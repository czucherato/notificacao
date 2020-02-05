using System;
using System.Linq.Expressions;
using FluentValidation.Results;
using System.Collections.Generic;
using Notificacao.Interfaces.Validacao;
using Notificacao.Auxiliares.Extensions;

namespace Notificacao.Validacao
{
    public class NotificarValidacao : INotificarValidacao
    {
        public NotificarValidacao()
        {
            Validacao = new List<INotificacao>();
        }

        public IList<INotificacao> Validacao { get; private set; }

        public void Adicionar(string mensagem) => Validacao.Add(new Notificacao(mensagem));

        public void Adicionar<TSource, TProperty>(string mensagem, TSource source, Expression<Func<TSource, TProperty>> expression)
        {
            Validacao.Add(new Notificacao(mensagem, PropertyInfoExtension.GetPropertyInfo(source, expression).Name));
        }

        public void Adicionar(ValidationResult result)
        {
            ((List<ValidationFailure>)result.Errors).ForEach(x => Validacao.Add(new Notificacao(x.ErrorMessage, x.PropertyName)));
        }

        public void Adicionar(INotificarValidacao notificacao)
        {
            ((List<INotificacao>)notificacao.Validacao).ForEach(x => Validacao.Add(new Notificacao(x.Mensagem, x.Referencia)));
        }

        public bool HaNotificacoes() => Validacao.Count > 0;

        public void Limpar() => Validacao.Clear();
    }
}