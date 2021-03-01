namespace Old
{
    public interface IResolveTurnEventHandler
    {
        delegate void ResolveTurnEventHandler();
        event ResolveTurnEventHandler OnResolveTurn;
    }
}