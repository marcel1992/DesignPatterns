using System;

namespace ObserverPattern
{
    public class ObserverType2 : IObserver
    {
        string nameOfObserver;
        public ObserverType2(string name)
        {
            nameOfObserver = name;
        }
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"{nameOfObserver} has received an alert from {celebrity.Name}. Updated value is: {celebrity.Flag}");
        }
    }
}
