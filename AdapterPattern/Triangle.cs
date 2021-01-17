namespace AdapterPattern
{
    public class Triangle : ITriangle
    {
        double _baseLength;
        double _height;

        public Triangle(double length, double height)
        {
            _baseLength = length;
            _height = height;
        }
        public void AboutMe()
        {
            System.Console.WriteLine("Actually, I am a Triangle!");
        }

        public double CalculateArea()
        {
            return 0.5 * _baseLength * _height;
        }
    }
}
