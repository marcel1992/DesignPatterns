namespace SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            System.Console.WriteLine("The dog says: I prefer barking");
        }
    }
}
