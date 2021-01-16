namespace AbstractFactoryPattern
{
    public class WildDog : IDog
    {
        public void AboutMe()
        {
            System.Console.WriteLine("Wild dog says: I prefer to roam freely in jungles!");
        }
    }
}
