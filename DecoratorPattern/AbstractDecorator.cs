namespace DecoratorPattern
{
    public class AbstractDecorator : AbstractHome
    {
        protected AbstractHome _home;

        public AbstractDecorator(AbstractHome home)
        {
            _home = home;
            AdditionalPrice = 0;
        }
        public override void MakeHome()
        {
            _home.MakeHome();
        }
    }
}
