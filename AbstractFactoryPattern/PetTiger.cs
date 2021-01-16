namespace AbstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void AboutMe()
        {
            System.Console.WriteLine("Pet tiger says: I play in an animal circus!");
        }
    }
}
