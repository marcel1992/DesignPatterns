using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern");
            //we have 4 observers - 2 of them are ObserverType1 and 2 are ObserverType2

            var myObserver1 = new ObserverType1("Roy");
            var myObserver2 = new ObserverType1("Kevin");
            var myObserver3 = new ObserverType2("Bose");
            var myObserver4 = new ObserverType2("Jacklin");

            Console.WriteLine("Working with first celebrity now!");

            ICelebrity celebrity = new Celebrity("Celebrity-1");
            //registering the observers - Roy, Kevin, Bose

            celebrity.Register(myObserver1);
            celebrity.Register(myObserver2);
            celebrity.Register(myObserver3);

            Console.WriteLine("Celebrity-1 is setting Flag = 5");

            celebrity.Flag = 5;

            //Kevin doesn't want to get further notification
            //unregistering the observer(Kevin)

            Console.WriteLine("Celebrity-1 is removing Kevin from the observer list now");
            celebrity.Unregister(myObserver2);

            Console.WriteLine("Celebrity-1 is setting Flag = 50");
            celebrity.Flag = 50;

            //Kevin is registering himself again
            celebrity.Register(myObserver2);

            Console.WriteLine("Celebrity-1 is setting Flag = 100");
            celebrity.Flag = 100;

            Console.WriteLine("Working with another celebrity now!");
            ICelebrity celebrity2 = new Celebrity("Celebrity-2");

            //registering the observers Roy and Jacklin
            celebrity2.Register(myObserver1);
            celebrity2.Register(myObserver4);

            Console.WriteLine("Celebrity-2 is setting Flag = 500");
            celebrity2.Flag = 500;
            Console.Read();
        }
    }
}
