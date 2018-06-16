namespace CodeOfKutulu
{
    public interface IGameAction
    {
        string Message { get; }
        Cancelable ApplyTo(State state);
    }
}