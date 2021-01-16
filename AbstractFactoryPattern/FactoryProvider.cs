namespace AbstractFactoryPattern
{
    public class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Wild:
                    return new WildAnimalFactory();
                case AnimalType.Pet:
                    return new PetAnimalFactory();
                default:
                    return new PetAnimalFactory();
            }
        }
    }
}
