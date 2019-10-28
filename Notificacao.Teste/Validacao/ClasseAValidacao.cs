using FluentValidation;
using Notificacao.Recursos;

namespace Notificacao.Teste.Validacao
{
    internal class ClasseAValidacao : AbstractValidator<ClasseA>
    {
        public ClasseAValidacao()
        {
            RuleFor(x => x.Valor1)
                .NotNull()
                .When(x => !Equals(x.Valor1, null))
                .NotEmpty()
                .WithMessage(Mensagem.Obrigatorio);
        }
    }
}
