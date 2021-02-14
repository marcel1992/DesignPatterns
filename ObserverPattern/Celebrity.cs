using System.Collections.Generic;

namespace ObserverPattern
{
    public class Celebrity : ICelebrity
    {
        public Celebrity(string name)
        {
            this.name = name;
        }
        List<IObserver> observerList = new List<IObserver>();
        private string name;
        public string Name => name;

        private int flag;
        public int Flag
        {
            get => flag;
            set
            {
                flag = value;
                NotifyRegisteredUsers();
            }
        }

        //notify all registered observers
        public void NotifyRegisteredUsers()
        {
            foreach (var observer in observerList)
            {
                observer.Update(this);
            }
        }

        //to register an observer
        public void Register(IObserver o)
        {
            observerList.Add(o);
        }

        //to unregister an observer
        public void Unregister(IObserver o)
        {
            observerList.Remove(o);
        }
    }
}
