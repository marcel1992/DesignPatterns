namespace AbstractFactoryPattern
{
    public class PetDog : IDog
    {
        public void AboutMe()
        {
            System.Console.WriteLine("Pet dog says: I prefer to stay at home!");
        }
    }
}
