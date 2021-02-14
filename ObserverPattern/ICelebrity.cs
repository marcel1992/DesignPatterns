namespace ObserverPattern
{
    public interface ICelebrity
    {
        string Name { get; }
        int Flag { get; set; }
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyRegisteredUsers();
    }
}