using System;

namespace ObserverPattern
{
    public class ObserverType1 : IObserver
    {
        string nameOfObserver;
        public ObserverType1(string name)
        {
            nameOfObserver = name;
        }
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"{nameOfObserver} has received an alert from {celebrity.Name}. Updated value is: {celebrity.Flag}");
        }
    }
}
