namespace AdapterPattern
{
    /*
     * RectangleAdapter is implementing IRectangle. So, it needs to implement all the methods
     * defined in the target interface
     */ 
    public class RectangleAdapter : IRectangle
    {
        ITriangle _triangle;
        public RectangleAdapter(ITriangle triangle)
        {
            _triangle = triangle;
        }
        public void AboutMe()
        {
            _triangle.AboutMe();
        }

        public double CalculateArea()
        {
            return _triangle.CalculateArea();
        }
    }
}
