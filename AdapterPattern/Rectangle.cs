namespace AdapterPattern
{
    public class Rectangle : IRectangle
    {
        double _length;
        public double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public void AboutMe()
        {
            System.Console.WriteLine("Actually, I am a Rectangle!");
        }

        public double CalculateArea()
        {
            return _length * _width;
        }
    }
}
