namespace AbstractFactoryPattern
{
    public class WildTiger : ITiger
    {
        public void AboutMe()
        {
            System.Console.WriteLine("Wild tiger says: I prefer hunting in jungles!");
        }
    }
}
