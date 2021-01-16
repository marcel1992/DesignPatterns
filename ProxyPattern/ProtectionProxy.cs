using System.Linq;

namespace ProxyPattern
{
    public class ProtectionProxy : Subject
    {
        Subject subject;
        string[] registeredUsers;
        string _currentUser;

        public ProtectionProxy(string currentUser)
        {
            registeredUsers = new string[] { "Admin", "Jack", "Sam" };
            _currentUser = currentUser;
        }
        public override void DoSomeWork()
        {
            System.Console.WriteLine($"{_currentUser} wants to access the system.");
            if (registeredUsers?.Contains(_currentUser) == true)
            {
                System.Console.WriteLine($"Welcome, {_currentUser}");
                if (subject == null)
                    subject = new ConcreteSubject();

                subject.DoSomeWork();
            }
            else
            {
                System.Console.WriteLine($"Sorry {_currentUser}, you do not have access into the system!");
            }
        }
    }
}
