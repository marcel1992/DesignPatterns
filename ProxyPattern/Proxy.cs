namespace ProxyPattern
{
    public class Proxy : Subject
    {
        Subject subject;
        public override void DoSomeWork()
        {
            System.Console.WriteLine("Welcome, my client.");
            //Lazy initialization: we'll not instantiate the object until the method is called

            if (subject == null)
                subject = new ConcreteSubject();

            subject.DoSomeWork();
        }
    }
}
