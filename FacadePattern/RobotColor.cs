namespace FacadePattern
{
    public class RobotColor
    {
        string _color;
        public RobotColor(string color)
        {
            _color = color;
        }
        public void SetColor()
        {
            if(_color == "steel")
                System.Console.WriteLine($"The default color {_color} is set for the robot.");
            else
                System.Console.WriteLine($"Painting the robot with your favourite {_color} color.");
        }
        public void RemoveColor()
        {
            System.Console.WriteLine("Attempting to remove the colors from the robot.");
        }
    }
}
