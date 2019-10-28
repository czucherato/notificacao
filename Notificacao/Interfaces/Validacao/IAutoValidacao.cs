namespace Notificacao.Interfaces.Validacao
{
    public interface IAutoValidacao
    {
        INotificarValidacao Notificacoes { get; }

        bool EhValido();
    }
}
