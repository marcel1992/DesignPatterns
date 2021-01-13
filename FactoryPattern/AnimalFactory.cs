namespace FactoryPattern
{
    public abstract class AnimalFactory
    {
        /*
         * GOF definition:
         * Factory method lets a class defer instantiation to subclasses.
         * The following method will create a tiger or a dog object, but at this point it does not know whether it will get a dog or a tiger.
         * It will be decided by the subclasses i.e. DogFactory or TigerFactory.
         * So, the following method is acting like a factory (of creation)
         */

        public abstract IAnimal CreateAnimal(string animalType);
    }
}
